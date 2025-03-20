using Factory.PL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Factory.PL.Controllers
{
    public class OnboardingUserController : Controller
    {
        private readonly IUserService _userService;

        public OnboardingUserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Welcome()
        {
            var user = await _userService.GetCurrentUserAsync();

            if (user == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            if (user.IsFirstLogin)
            {
                user.IsFirstLogin = false;
                await _userService.UpdateUserAsync(user);

                return View();
            }

            return RedirectToAction("Dashboard", "Home");
        }

        public async Task<IActionResult> TourComplete()
        {
            var user = await _userService.GetCurrentUserAsync();

            if (user == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            user.HasCompletedTour = true;

            await _userService.UpdateUserAsync(user);

            return RedirectToAction("Dashboard", "Home");
        }
    }
}