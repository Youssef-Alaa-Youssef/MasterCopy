using Factory.DAL.Enums;
using Factory.DAL.Models.Auth;
using Factory.PL.Helper;
using Factory.PL.Options;
using Factory.PL.Services.Email;
using Factory.PL.ViewModels;
using Factory.PL.ViewModels.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Text;
namespace Factory.Controllers
{
    public class AuthController : Controller
    {
        private readonly EmailConfiguration _emailconfig;
        private readonly IWebHostEnvironment _environment;
        private readonly IEmailService _emailService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly CompanyDetails _companydetails;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IOptions<Names> _appsettings;

        public AuthController(IOptions<Names> appsettings, EmailConfiguration emailconfig, IWebHostEnvironment environment, IEmailService EmailService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<CompanyDetails> companydetails, RoleManager<IdentityRole> roleManager)
        {
            _emailconfig = emailconfig;
            _environment = environment;
            _emailService = EmailService;
            _userManager = userManager;
            _signInManager = signInManager;
            _companydetails = companydetails.Value;
            _roleManager = roleManager;
            _appsettings = appsettings;
        }

        [CheckPermission(Permissions.Read)]
        public async Task<IActionResult> Index(string query = "", int page = 1, int pageSize = 10)
        {
            try
            {
                var excludedEmail = _appsettings.Value.ExcludedEmail;
                var usersQuery = _userManager.Users
                    .AsNoTracking()
                    .Where(u => u.NormalizedEmail != excludedEmail);

                if (!string.IsNullOrEmpty(query))
                {
                    usersQuery = usersQuery.Where(u => (u.UserName ?? "").Contains(query));
                }

                var totalUsers = await usersQuery.CountAsync();
                var users = await usersQuery
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var activeUsers = new List<UserViewModel>();
                var lockedUsers = new List<UserViewModel>();

                foreach (var user in users)
                {
                    var userViewModel = new UserViewModel
                    {
                        Id = user.Id,
                        UserName = user.UserName ?? "",
                        IsActive = user.LockoutEnabled
                    };

                    if (userViewModel.IsActive)
                    {
                        activeUsers.Add(userViewModel);
                    }
                    else
                    {
                        lockedUsers.Add(userViewModel);
                    }
                }

                var paginationViewModel = new PaginationViewModel<UserViewModel>
                {
                    ActiveUsers = activeUsers,
                    LockedUsers = lockedUsers,
                    Query = query,
                    Page = page,
                    PageSize = pageSize,
                    TotalItems = totalUsers
                };

                return View(paginationViewModel);
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = "An error occurred while fetching users. Please try again later.";
                return RedirectToAction(nameof(HomeController));
            }
        }
       
        public IActionResult LogIn(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            var model = new LogInViewModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LogInViewModel model, CancellationToken cancellationToken, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(model);

            returnUrl = model.ReturnUrl ?? Url.Content("~/");

            if (!string.IsNullOrEmpty(returnUrl) && !Url.IsLocalUrl(returnUrl))
            {
                returnUrl = Url.Content("~/");
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData["Error"] = "Invalid Email Or Password.";
                return View(model);
            }

            if (await _userManager.GetTwoFactorEnabledAsync(user))
            {
                var isPasswordValid = await _userManager.CheckPasswordAsync(user, model.Password);
                if (!isPasswordValid)
                {
                    TempData["Error"] = "Invalid Email Or Password.";
                    return View(model);
                }

                await HttpContext.SignInAsync(
                    IdentityConstants.TwoFactorUserIdScheme,
                    StoreTwoFactorInfo(user.Id, "Authenticator"));

                // Redirect to 2FA verification
                return RedirectToAction("LoginWith2fa", new
                {
                    ReturnUrl = returnUrl,
                    RememberMe = model.RememberMe,
                    Provider = "Authenticator"
                });
            }

            var result = await _signInManager.PasswordSignInAsync(
                user,
                model.Password,
                model.RememberMe,
                lockoutOnFailure: true);

            if (result.Succeeded)
            {
                // Add claims if needed
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.NameIdentifier, user.Id)
        };

                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var role in userRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }

                var identity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);

                if (user.IsFirstLogin)
                {
                    return RedirectToAction("Welcome", "OnboardingUser");
                }

                TempData["Success"] = "Login Successful!";
                return LocalRedirect(returnUrl);
            }
            else if (result.RequiresTwoFactor)
            {
                await HttpContext.SignInAsync(
                    IdentityConstants.TwoFactorUserIdScheme,
                    StoreTwoFactorInfo(user.Id, "Authenticator"));

                return RedirectToAction("LoginWith2fa", new
                {
                    ReturnUrl = returnUrl,
                    RememberMe = model.RememberMe
                });
            }
            else if (result.IsLockedOut)
            {
                TempData["Error"] = "Account locked out due to multiple failed attempts. Please try again later.";
                return View(model);
            }
            else if (!user.EmailConfirmed)
            {
                ModelState.AddModelError(string.Empty, "Your account needs to be activated.");
                ModelState.AddModelError(string.Empty, "Please check your email for the activation link.");
                return View(model);
            }

            TempData["Error"] = "Invalid Email Or Password.";
            return View(model);
        }

        private ClaimsPrincipal StoreTwoFactorInfo(string userId, string provider)
        {
            var identity = new ClaimsIdentity(IdentityConstants.TwoFactorUserIdScheme);
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userId));
            identity.AddClaim(new Claim("amr", provider));
            return new ClaimsPrincipal(identity);
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpViewModel model, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return View(model);

            var existingUser = await _userManager.FindByEmailAsync(model.Email);
            if (existingUser != null)
            {
                TempData["Error"] = "Email is already in use.";
                return View(model);
            }

            var newUser = new ApplicationUser { PhoneNumber = model.PhoneNumber, UserName = model.UserName, Email = model.Email }; // Adjust this line based on your ApplicationUser model
            var result = await _userManager.CreateAsync(newUser, model.Password);
            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                var confirmationLink = Url.Action("ConfirmEmail", "Auth",
                new { userId = newUser.Id, token = token }, Request.Scheme);
                string subject = "Activate Your Account";

                string body = $@"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Activate Your Account</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Roboto:wght@400;700&display=swap');

        body {{
            margin: 0;
            padding: 0;
            font-family: 'Roboto', Arial, sans-serif;
            background-color: #f8f9fa;
            color: #333;
        }}

        .container {{
            width: 100%;
            max-width: 600px;
            margin: 20px auto;
            background-color: #ffffff;
            border-radius: 8px;
            overflow: hidden;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border: 1px solid #e0e0e0;
        }}

        .header {{
            background: url('/assets/images/Login.png');
            background-size: cover;
            height: 200px;
            border-bottom: 1px solid #e0e0e0;
        }}

        .content {{
            padding: 30px;
            text-align: center;
        }}

        h1 {{
            font-size: 28px;
            color: #007bff;
            margin-bottom: 20px;
            font-weight: 700;
        }}

        p {{
            font-size: 16px;
            line-height: 1.5;
            margin: 0 0 20px;
        }}

        .button {{
            display: inline-block;
            padding: 15px 30px;
            background-color: #007bff;
            color: #ffffff;
            text-decoration: none;
            border-radius: 5px;
            font-size: 16px;
            font-weight: 700;
            text-align: center;
            margin: 20px 0;
            border: 1px solid #007bff;
        }}

        .button:hover {{
            background-color: #0056b3;
            border-color: #0056b3;
        }}

        .footer {{
            background-color: #f4f4f4;
            text-align: center;
            padding: 20px;
            font-size: 14px;
            color: #666;
        }}

        .footer a {{
            color: #007bff;
            text-decoration: none;
        }}

        .footer a:hover {{
            text-decoration: underline;
        }}

        /* Responsive Styles */
        @media only screen and (max-width: 600px) {{
            .header {{
                height: 150px; /* Adjust header height for smaller screens */
            }}

            h1 {{
                font-size: 20px; /* Adjust font size for smaller screens */
            }}

            .button {{
                padding: 12px 20px; /* Adjust button padding for smaller screens */
                font-size: 14px; /* Adjust font size for smaller screens */
            }}

            .content {{
                padding: 20px; /* Adjust content padding for smaller screens */
            }}
        }}
    </style>
</head>
<body>
    <div class=""container"">
        <div class=""header""></div>
        <div class=""content"">
            <h1>Activate Your Account</h1>
            <p>Hi {newUser.UserName},</p>
            <p>Thank you for registering with us. To complete your registration, please click the button below to activate your account.</p>
            <a href=""{confirmationLink}"" class=""button"">Activate Account</a>
            <p>If you did not register for an account, you can safely ignore this email.</p>
        </div>
        <div class=""footer"">
            <p>Best regards,</p>
            <p>{_companydetails.Name} - {_companydetails.PhoneNumber}</p>
            <p><a asp-action=""ContactUs"" asp-controller=""Home"">Contact Us</a></p>
        </div>
    </div>
</body>
</html>
";

                await _emailService.SendEmailAsync(newUser.Email, subject, body);


                return RedirectToAction(nameof(Confirmation));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }


        public IActionResult Confirmation()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToAction("Error");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "Please provide valid credentials.";

                return RedirectToAction("Error");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                TempData["Success"] = "Account Activated Successfully.";
                return RedirectToAction("Activated");
            }

            return RedirectToAction("Error");
        }
        public IActionResult Activated()
        {
            return View();
        }
        public IActionResult forgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> forgotPassword(RestPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
                {
                    TempData["Error"] = "It seems you don't have an account with us. Please register to create a new account.";
                    return RedirectToAction(nameof(forgotPassword));
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Action("ActualRestPassword", "Auth", new { userId = user.Id, token }, protocol: HttpContext.Request.Scheme);
                string subject = "Reset Your Password";
                string body = $@"
                <html>
                <head>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            line-height: 1.6;
                            background-color: #f7f7f7;
                            padding: 20px;
                        }}
                        .container {{
                            max-width: 600px;
                            margin: 0 auto;
                            background-color: #fff;
                            padding: 30px;
                            border-radius: 5px;
                            box-shadow: 0 0 10px rgba(0,0,0,0.1);
                        }}
                        .btn {{
                            display: inline-block;
                            background-color: #007bff;
                            color: #fff;
                            text-decoration: none;
                            padding: 10px 20px;
                            border-radius: 5px;
                        }}

                    </style>
                </head>
                <body>
                    <div class='container'>
                        <h2>Hello, {user.UserName}</h2>
                        <p>We received a request to reset your password. Click the button below to reset it:</p>
                        <p><a class='btn' href='{callbackUrl}'>Reset Password</a></p>
                        <p>If you did not request a password reset, you can ignore this email.</p>
                        <p>Best regards,<br>{_emailconfig.DisplayName} Application Team</p>
                    </div>
                </body>
                </html>
            ";

                await _emailService.SendEmailAsync(user.Email ?? "", subject, body);
                return RedirectToAction(nameof(forgotPassword));
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult ActualRestPassword(string userId, string token)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                TempData["Error"] = "Please provide valid credentials.";
                return RedirectToAction(nameof(ForgotPassword));
            }

            var model = new ActualRestPasswordViewModel
            {
                UserId = userId,
                Token = token
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ActualRestPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("ActualRestPassword", model);
            }

            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid request.");
                return View("ActualRestPassword", model);
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                TempData["Success"] = "Your password has been reset successfully. You can now log in.";
                return RedirectToAction("Login", "Auth");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            TempData["Error"] = "Failed to reset password. Please try again.";
            return View("ActualRestPassword", model);
        }

        [CheckPermission(Permissions.Read)]

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new UserDetailsViewModel
            {
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                PhoneNumber = user.PhoneNumber ?? string.Empty
            };

            return View(viewModel);
        }
        [CheckPermission(Permissions.Update)]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new UserEditViewModel
            {
                Id = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                PhoneNumber = user.PhoneNumber ?? string.Empty,
                IsActive = user.LockoutEnabled
            };

            return View(viewModel);
        }
        [CheckPermission(Permissions.Update)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, UserEditViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);

                if (user == null)
                {
                    return NotFound();
                }

                user.UserName = model.UserName;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.LockoutEnabled = model.IsActive;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }
        [CheckPermission(Permissions.Delete)]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new UserDetailsViewModel
            {
                Id = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                PhoneNumber = user.PhoneNumber ?? string.Empty
            };

            return View(viewModel);
        }
        [CheckPermission(Permissions.Delete)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            var viewModel = new UserDetailsViewModel
            {
                Id = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                PhoneNumber = user.PhoneNumber ?? string.Empty
            };

            return View(viewModel);
        }

        public IActionResult LogOut()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ActualLogOut()
        {
            TempData["Success"] = "You have been successfully logged out";
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var userId = User?.Identity?.Name;
            if (userId == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            var user = await _userManager.FindByNameAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var model = new ApplicationUserViewModel
            {
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                ProfilePictureUrl = user.ProfilePictureUrl ?? string.Empty,
                Roles = (await _userManager.GetRolesAsync(user)).ToList()
            };

            return View(model);
        }
        public IActionResult Settings()
        {
            return View();
        }
        public async Task<IActionResult> TwoFactorSettings()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var isTwoFactorEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var hasAuthenticatorApp = await _userManager.GetAuthenticatorKeyAsync(user) != null;

            var model = new TwoFactorSettingsViewModel
            {
                IsTwoFactorEnabled = isTwoFactorEnabled,
                IsAuthenticatorAppEnabled = hasAuthenticatorApp,
                PhoneNumber = phoneNumber ?? string.Empty
            };

            return View(model);
        }



        [HttpGet]
        public async Task<IActionResult> EnableAuthenticator()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return NotFound("User ID not found in claims.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            await LoadSharedKeyAndQrCodeUriAsync(user);
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleTwoFactorAuthentication(bool EnableMFA)
        {
            var userId = _userManager.GetUserId(User);
            if (string.IsNullOrEmpty(userId))
            {
                return NotFound("User ID not found in claims.");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            try
            {
                if (EnableMFA)
                {
                    var is2faAlreadyEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
                    if (is2faAlreadyEnabled)
                    {
                        TempData["Success"] = "Two-factor authentication is already enabled.";
                        return RedirectToAction("SecuritySettings");
                    }

                    await LoadSharedKeyAndQrCodeUriAsync(user);
                    return View("EnableAuthenticator");
                }
                else
                {
                    var is2faEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
                    if (!is2faEnabled)
                    {
                        TempData["Success"] = "Two-factor authentication is already disabled.";
                        return RedirectToAction("Index","Settings");
                    }

                    var disableResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
                    if (!disableResult.Succeeded)
                    {
                        TempData["Error"] = "Failed to disable two-factor authentication.";
                        return RedirectToAction("SecuritySettings");
                    }

                    await _userManager.ResetAuthenticatorKeyAsync(user);


                    TempData["Success"] = "Two-factor authentication has been disabled.";
                    return RedirectToAction("SecuritySettings");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An unexpected error occurred. Please try again.";
                return RedirectToAction("SecuritySettings");
            }
        }
        private async Task LoadSharedKeyAndQrCodeUriAsync(ApplicationUser user)
        {
            var unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
            if (string.IsNullOrEmpty(unformattedKey))
            {
                await _userManager.ResetAuthenticatorKeyAsync(user);
                unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
            }

            var email = await _userManager.GetEmailAsync(user);
            var authenticatorUri = GenerateQrCodeUri(email, unformattedKey);

            ViewData["SharedKey"] = FormatKey(unformattedKey);
            ViewData["AuthenticatorUri"] = authenticatorUri;
            ViewData["Is2faEnabled"] = await _userManager.GetTwoFactorEnabledAsync(user); ;
        }

        private string FormatKey(string unformattedKey)
        {
            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }
            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }

        private string GenerateQrCodeUri(string email, string unformattedKey)
        {
            return string.Format(
                "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6",
                Uri.EscapeDataString(_appsettings.Value.CompanyName),
                Uri.EscapeDataString(email),
                unformattedKey);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableAuthenticator(EnableAuthenticatorViewModel model)
        {
            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadSharedKeyAndQrCodeUriAsync(user);
                return View(model);
            }

            var verificationCode = model.Code.Replace(" ", string.Empty).Replace("-", string.Empty);
            var is2faTokenValid = await _userManager.VerifyTwoFactorTokenAsync(
                user, _userManager.Options.Tokens.AuthenticatorTokenProvider, verificationCode);

            if (!is2faTokenValid)
            {
                ModelState.AddModelError("Code", "Verification code is invalid.");
                await LoadSharedKeyAndQrCodeUriAsync(user);
                return View(model);
            }

            await _userManager.SetTwoFactorEnabledAsync(user, true);

            // Store codes in database temporarily
            var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
            user.RecoveryCodes = string.Join(";", recoveryCodes);
            await _userManager.UpdateAsync(user);

            return RedirectToAction("ShowRecoveryCodes");
        }

        [HttpGet]
        public async Task<IActionResult> ShowRecoveryCodes()
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            if (TempData["RecoveryCodes"] is string[] recoveryCodes)
            {
                var model = new ShowRecoveryCodesViewModel { RecoveryCodes = recoveryCodes };
                return View(model);
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                return RedirectToAction("TwoFactorAuthentication");
            }

            recoveryCodes = (await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10)).ToArray();
            var modelWithNewCodes = new ShowRecoveryCodesViewModel { RecoveryCodes = recoveryCodes };
            return View(modelWithNewCodes);
        }

        [HttpGet]
        public async Task<IActionResult> LoginWith2fa(bool rememberMe, string returnUrl, string provider)
        {
            var result = await HttpContext.AuthenticateAsync(IdentityConstants.TwoFactorUserIdScheme);
            if (!result.Succeeded)
            {
                TempData["Error"] = "Your login session has expired. Please log in again.";
                return RedirectToAction("Login");
            }

            var userId = result.Principal.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("Login");
            }

            var model = new LoginWith2faViewModel
            {
                RememberMe = rememberMe,
                ReturnUrl = returnUrl,
                Provider = provider
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginWith2fa(LoginWith2faViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await HttpContext.AuthenticateAsync(IdentityConstants.TwoFactorUserIdScheme);
            if (!result.Succeeded)
            {
                TempData["Error"] = "Your login session has expired. Please log in again.";
                return RedirectToAction("Login");
            }

            var userId = result.Principal.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                TempData["Error"] = "User not found.";
                return RedirectToAction("Login");
            }

            var authenticatorCode = model.TwoFactorCode.Replace(" ", string.Empty).Replace("-", string.Empty);

            var is2faTokenValid = await _userManager.VerifyTwoFactorTokenAsync(
                user, _userManager.Options.Tokens.AuthenticatorTokenProvider, authenticatorCode);

            if (!is2faTokenValid)
            {
                TempData["Error"] = "Invalid verification code.";
                ModelState.AddModelError(string.Empty, "Invalid verification code.");
                return View(model);
            }

            await HttpContext.SignOutAsync(IdentityConstants.TwoFactorUserIdScheme);

            await _signInManager.SignInAsync(user, model.RememberMe, IdentityConstants.TwoFactorUserIdScheme);

            return LocalRedirect(model.ReturnUrl ?? Url.Content("~/"));
        }

        [HttpGet]
        public async Task<IActionResult> GenerateRecoveryCodes()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                return RedirectToAction("EnableAuthenticator");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GenerateRecoveryCodesPost()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                return RedirectToAction("EnableAuthenticator");
            }

            var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
            TempData["RecoveryCodes"] = recoveryCodes.ToArray();

            return RedirectToAction("ShowRecoveryCodes");
        }


        [CheckPermission(Permissions.Create)]
        public async Task<IActionResult> Add()
        {
            var viewModel = new UserCreateViewModel
            {
                Roles = await GetRolesAsync(),
                IsActive = true // Default to active
            };

            return View(viewModel);
        }
        [CheckPermission(Permissions.Create)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(UserCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Roles = await GetRolesAsync(); // Repopulate roles if validation fails
                return View(model);
            }

            var result = await CreateUserAsync(model);

            if (result.Succeeded)
            {
                TempData["Success"] = "User created successfully!";
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            model.Roles = await GetRolesAsync(); // Repopulate roles if user creation fails
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAccount()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            user.DeleteRequestedOn = DateTime.UtcNow;
            await _userManager.UpdateAsync(user);

            await _userManager.UpdateSecurityStampAsync(user); // Invalidate the user's security stamp
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [CheckPermission(Permissions.Update)]

        public async Task<IActionResult> UpdateRole([FromBody] UpdateRoleModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid request.");
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            var hasRole = await _userManager.IsInRoleAsync(user, model.Role);
            if (!hasRole)
            {
                return BadRequest("User does not have the requested role.");
            }

            var claims = await _userManager.GetClaimsAsync(user);
            var roleClaims = claims.Where(c => c.Type == ClaimTypes.Role).ToList();
            foreach (var claim in roleClaims)
            {
                await _userManager.RemoveClaimAsync(user, claim);
            }

            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, model.Role));
            await _signInManager.RefreshSignInAsync(user);

            return Ok(new { message = "Role updated successfully.", redirectUrl = $"/Dashboard/{model.Role}" });
        }
        private async Task<List<SelectListItem>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles
                .Where(r => r.Name != UserRole.MasterCopy.ToString())
                .Select(r => new SelectListItem
                {
                    Value = r.Name,
                    Text = r.Name
                })
                .ToListAsync();

            return roles;
        }
        private async Task<IdentityResult> CreateUserAsync(UserCreateViewModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                LockoutEnabled = model.IsActive,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded && !string.IsNullOrEmpty(model.SelectedRole))
            {
                await _userManager.AddToRoleAsync(user, model.SelectedRole);
            }

            return result;
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePasswordLogedUser(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                TempData["Success"] = "Your password has been changed successfully.";
                return Redirect("/");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View("ChangePassword", model);
        }


        public IActionResult FacebookLogin()
        {
            var redirectUrl = Url.Action("FacebookCallback", "Auth");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, "Facebook");
        }

        public IActionResult MicrosoftLogin()
        {
            var redirectUrl = Url.Action("MicrosoftCallback", "Auth");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, "Microsoft");
        }

        public IActionResult GoogleLogin()
        {
            var redirectUrl = Url.Action("GoogleCallback", "Auth");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, "Google");
        }

        public async Task<IActionResult> FacebookCallback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync("Facebook");

            if (!authenticateResult.Succeeded)
                return RedirectToAction("Login"); 

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> MicrosoftCallback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync("Microsoft");

            if (!authenticateResult.Succeeded)
                return RedirectToAction("Login"); 

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> GoogleCallback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync("Google");

            if (!authenticateResult.Succeeded)
                return RedirectToAction("Login"); 

            return RedirectToAction("Index", "Home");
        }
    }
}
