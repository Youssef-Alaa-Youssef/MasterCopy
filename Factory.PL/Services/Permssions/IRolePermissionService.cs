using Factory.DAL.Models.Permission;
using Factory.PL.ViewModels.Permissions;
using System.Security.Claims;

namespace Factory.PL.Services.Permssions
{
    public interface IRolePermissionService
    {
        Task<RolePermissionV2ViewModel> GetRolePermissionViewModelAsync();
        Task<List<RolePermission>> GetExistingPermissionsAsync(string roleId, int moduleId, int subModuleId);
        Task SaveRolePermissionAsync(RolePermissionV2ViewModel model);
        Task<List<SubModule>> GetSubModulesByModuleIdAsync(int moduleId);
        Task<List<Page>> GetPagesBySubModuleIdAsync(int subModuleId);
        Task<bool> CheckUserPermission(ClaimsPrincipal user, int pageId, int permissionId);
        Task<int?> GetPageIdByControllerAction(string controllerName, string actionName);
    }
}
