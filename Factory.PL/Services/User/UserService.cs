using Factory.BLL.InterFaces;
using Factory.DAL.Models;
using Factory.DAL.Models.Auth;
using Factory.PL.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
namespace Factory.PL.Services
{

    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(
            UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            IUnitOfWork unitOfWork)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        /// <summary>
        /// Gets the currently logged-in user
        /// </summary>
        public async Task<ApplicationUser> GetCurrentUserAsync()
        {
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return null;
            }

            return await _unitOfWork.GetRepository<ApplicationUser>()
                .GetFirstOrDefaultAsync(u => u.Id == userId);
        }

        /// <summary>
        /// Gets a user by their ID
        /// </summary>
        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                return null;
            }

            return await _unitOfWork.GetRepository<ApplicationUser>()
                .Query()
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        /// <summary>
        /// Gets a user by their email address
        /// </summary>
        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return null;
            }

            return await _unitOfWork.GetRepository<ApplicationUser>()
                .GetFirstOrDefaultAsync(u => u.NormalizedEmail == email.ToUpper());
        }

        /// <summary>
        /// Updates a user's information
        /// </summary>
        public async Task<bool> UpdateUserAsync(ApplicationUser user)
        {
            if (user == null)
            {
                return false;
            }

            await _unitOfWork.GetRepository<ApplicationUser>().UpdateAsync(user);
            var result = await _unitOfWork.SaveChangesAsync();
            return result > 0;
        }

        /// <summary>
        /// Records that a user has completed onboarding
        /// </summary>
        public async Task<bool> MarkOnboardingCompleteAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }

            user.IsFirstLogin = false;
            user.HasCompletedTour = true;
            return await UpdateUserAsync(user);
        }

        /// <summary>
        /// Gets the onboarding status for a user
        /// </summary>
        public async Task<UserOnboardingStatus> GetOnboardingStatusAsync(string userId)
        {
            var user = await GetUserByIdAsync(userId);
            if (user == null)
            {
                return null;
            }

            // Get the user's onboarding progress from the database
            //var onboardingProgress = await _unitOfWork.GetRepository<UserOnboardingProgress>()
            //    .GetFirstOrDefaultAsync(p => p.UserId == userId);

            return new UserOnboardingStatus
            {
                IsFirstLogin = user.IsFirstLogin,
                HasCompletedTour = user.HasCompletedTour,
                LastViewedStep = 1,
                AccountCreatedDate = user.AccountCreatedDate
            };
        }
    }
}