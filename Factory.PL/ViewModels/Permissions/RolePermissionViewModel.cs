using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.PL.ViewModels.Permissions
{
    public class RolePermissionViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public List<SelectListItem> Roles { get; set; } = new List<SelectListItem>();
        public List<ModulePermissionViewModel> Modules { get; set; } = new List<ModulePermissionViewModel>();
        public List<PermissionViewModel> Permissions { get; set; } = new List<PermissionViewModel>();
    }
}