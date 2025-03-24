using Microsoft.AspNetCore.Identity;

namespace Factory.DAL.Models.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
        public string ProfilePictureUrl { get; set; } = "/images/default-profile.png";
        public bool IsMFAEnabled { get; set; } = false;
        public bool IsDarkModeEnabled { get; set; } = false;
        public DateTime? LastBackupDate { get; set; }
        public DateTime? DeleteRequestedOn { get; set; }
        public bool IsFirstLogin { get; set; } = true;
        public bool HasCompletedTour { get; set; } = false;
        public DateTime AccountCreatedDate { get; set; } = DateTime.UtcNow;
        //public virtual UserPreferences UserPreferences { get; set; }
        public string? AuthenticatorKey { get; set; }
        public string? RecoveryCodes { get; set; }


    }

}
