using Factory.DAL.Models;
using Factory.DAL.Models.Auth;

namespace Factory.PL.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Gets the currently logged-in user
        /// </summary>
        Task<ApplicationUser> GetCurrentUserAsync();

        /// <summary>
        /// Gets a user by their ID
        /// </summary>
        Task<ApplicationUser> GetUserByIdAsync(string userId);

        /// <summary>
        /// Gets a user by their email address
        /// </summary>
        Task<ApplicationUser> GetUserByEmailAsync(string email);

        /// <summary>
        /// Updates a user's information
        /// </summary>
        Task<bool> UpdateUserAsync(ApplicationUser user);

        /// <summary>
        /// Records that a user has completed onboarding
        /// </summary>
        Task<bool> MarkOnboardingCompleteAsync(string userId);

        /// <summary>
        /// Gets the onboarding status for a user
        /// </summary>
        Task<UserOnboardingStatus> GetOnboardingStatusAsync(string userId);
    }
}