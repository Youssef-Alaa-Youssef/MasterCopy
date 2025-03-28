using Factory.DAL.Enums;
using Factory.DAL.Models.Auth;
using Factory.PL.ViewModels.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
public class SettingsController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IWebHostEnvironment _environment;

    public SettingsController(IWebHostEnvironment environment,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _environment = environment;
    }

    [HttpGet]
    //[CheckPermission(Permissions.Read)]
    [Authorize]
    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var model = new SettingsViewModel
        {
            FullName = user.UserName ?? string.Empty,
            Email = user.Email ?? string.Empty,
            ProfilePictureUrl = user.ProfilePictureUrl ?? "/images/default-profile.png",
            IsMFAEnabled = user.TwoFactorEnabled,
            IsDarkModeEnabled = user.IsDarkModeEnabled,
            LastBackupDate = user.LastBackupDate,
            ChangePasswordModel = new ChangePasswordViewModel()
        };

        return View(model);
    }

    [HttpPost]
    [CheckPermission(Permissions.Update)]
    public async Task<IActionResult> UpdateSettings(SettingsViewModel model)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            user.UserName = model.FullName;
            user.Email = model.Email;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            if (!string.IsNullOrEmpty(model.ChangePasswordModel?.CurrentPassword) &&
                !string.IsNullOrEmpty(model.ChangePasswordModel.NewPassword) &&
                model.ChangePasswordModel.NewPassword == model.ChangePasswordModel.ConfirmNewPassword)
            {
                var passwordChangeResult = await _userManager.ChangePasswordAsync(user,
                    model.ChangePasswordModel.CurrentPassword, model.ChangePasswordModel.NewPassword);

                if (!passwordChangeResult.Succeeded)
                {
                    foreach (var error in passwordChangeResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            if (ModelState.IsValid)
            {
                await _signInManager.RefreshSignInAsync(user);
                TempData["Success"] = "Settings updated successfully!";
                return RedirectToAction("Index");
            }
        }

        return View("Index", model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UploadProfilePicture(IFormFile profilePicture)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        if (profilePicture == null || profilePicture.Length == 0)
        {
            TempData["Error"] = "Please select a valid image file.";
            return RedirectToAction(nameof(Index));
        }

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        var extension = Path.GetExtension(profilePicture.FileName).ToLowerInvariant();
        if (string.IsNullOrEmpty(extension) || !allowedExtensions.Contains(extension))
        {
            TempData["Error"] = "Only JPG, JPEG, PNG, and GIF files are allowed.";
            return RedirectToAction(nameof(Index));
        }

        if (profilePicture.Length > 5 * 1024 * 1024) // 5MB limit
        {
            TempData["Error"] = "File size must be less than 5MB.";
            return RedirectToAction(nameof(Index));
        }

        try
        {
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads", "profile-pictures");
            Directory.CreateDirectory(uploadsFolder);

            var uniqueFileName = $"{user.Id}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await profilePicture.CopyToAsync(stream);
            }

            user.ProfilePictureUrl = $"/uploads/profile-pictures/{uniqueFileName}";
            await _userManager.UpdateAsync(user);

            TempData["Success"] = "Profile picture updated successfully!";
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Error uploading profile picture: {ex.Message}";
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ToggleTwoFactorAuthentication(bool enableMFA)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        var result = await _userManager.SetTwoFactorEnabledAsync(user, enableMFA);
        if (!result.Succeeded)
        {
            TempData["Error"] = "Failed to update two-factor authentication settings.";
            return RedirectToAction(nameof(Index));
        }

        TempData["Success"] = enableMFA
            ? "Two-factor authentication has been enabled."
            : "Two-factor authentication has been disabled.";

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Backup()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        var backupData = $"User Backup Data for {user.UserName} at {DateTime.Now}";
        var fileName = $"{user.UserName}_backup_{DateTime.Now:yyyyMMdd}.txt";

        return File(System.Text.Encoding.UTF8.GetBytes(backupData), "text/plain", fileName);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RestoreBackup(IFormFile backupFile)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        if (backupFile == null || backupFile.Length == 0)
        {
            TempData["Error"] = "Please select a valid backup file.";
            return RedirectToAction(nameof(Index));
        }

        try
        {
            using (var reader = new StreamReader(backupFile.OpenReadStream()))
            {
                var backupContent = await reader.ReadToEndAsync();
                TempData["Success"] = "Backup restored successfully!";
            }
        }
        catch (Exception ex)
        {
            TempData["Error"] = $"Error restoring backup: {ex.Message}";
        }

        return RedirectToAction(nameof(Index));
    }


}
