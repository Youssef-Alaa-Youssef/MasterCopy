using Microsoft.AspNetCore.Identity;

namespace Factory.DAL.Models.Auth
{
    public class ApplicationRoles : IdentityRole
    {
        public ApplicationRoles() { }  

        public ApplicationRoles(string roleName) : base(roleName) { }

        public String NameAr { get; set; } = string.Empty;
    }
}
