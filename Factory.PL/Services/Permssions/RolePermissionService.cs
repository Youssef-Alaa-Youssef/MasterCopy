using Factory.BLL.InterFaces;
using Factory.DAL.Models.Permission;
using Factory.DAL.ViewModels.Permissions;
using Factory.PL.ViewModels.Permissions;
using Microsoft.AspNetCore.Identity;

namespace Factory.DAL.Services
{
    public class RolePermissionService
    {
        private readonly IUnitOfWork _context;

        public RolePermissionService(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<RolePermissionV2ViewModel> GetRolePermissionViewModelAsync()
        {
            var viewModel = new RolePermissionV2ViewModel
            {
                Modules = (await _context.GetRepository<Module>().GetAllAsync()).ToList(),
                Roles = (await _context.GetRepository<IdentityRole>().GetAllAsync()).ToList(),
                PermissionTypes = (await _context.GetRepository<PermissionTyepe>().GetAllAsync()).ToList()
            };

            return viewModel;
        }

        public async Task<List<SubModule>> GetSubModulesByModuleIdAsync(int moduleId)
        {
            return (await _context.GetRepository<SubModule>().GetAllAsync())
                .Where(sm => sm.ModuleId == moduleId)
                .ToList();
        }

        public async Task<List<Page>> GetPagesBySubModuleIdAsync(int subModuleId)
        {
            return (await _context.GetRepository<Page>().GetAllAsync())
                .Where(p => p.SubmoduleId == subModuleId)
                .ToList();
        }

        public async Task SaveRolePermissionAsync(RolePermissionV2ViewModel model)
        {
            var rolePermission = new RolePermission
            {
                RoleId = model.RoleId,
                PermissionId = model.PermissionId,
                ModuleId = model.ModuleId,
                SubModuleId = model.SubModuleId,
                PageId = model.PageId
            };

            await _context.GetRepository<RolePermission>().AddAsync(rolePermission);
            await _context.SaveChangesAsync();
        }
    }
}