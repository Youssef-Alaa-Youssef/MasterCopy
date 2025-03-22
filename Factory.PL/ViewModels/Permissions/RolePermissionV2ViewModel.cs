using Factory.DAL.Models.Permission;
using Microsoft.AspNetCore.Identity;
namespace Factory.DAL.ViewModels.Permissions
{
    public class RolePermissionV2ViewModel
    {
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public string RoleId { get; set; }
        public int PageId { get; set; }
        public int PermissionId { get; set; }

        public ICollection<Module> Modules { get; set; }
        public ICollection<SubModule> SubModules { get; set; }
        public ICollection<IdentityRole> Roles { get; set; }
        public ICollection<Page> Pages { get; set; }
        public ICollection<PermissionTyepe> PermissionTypes { get; set; }
    }
}