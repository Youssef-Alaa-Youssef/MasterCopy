using Factory.BLL.InterFaces;
using Factory.DAL.Enums;
using Factory.DAL.Models.Permission;
using Factory.PL.Services.Permissions;
using Factory.PL.Services.Permssions;
using Factory.PL.ViewModels.Permissions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Claims;

namespace Factory.DAL.Services
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly IUnitOfWork _context;
        private readonly IMemoryCache _memoryCache;

        public RolePermissionService(IUnitOfWork context, IMemoryCache memoryCache)
        {
            _context = context;
            _memoryCache = memoryCache;
        }
        public async Task<List<RolePermission>> GetExistingPermissionsAsync(string roleId, int moduleId, int subModuleId)
        {
            var allRolePermissions = await _context.GetRepository<RolePermission>().GetAllAsync();

            return allRolePermissions
                .Where(rp =>
                    rp.RoleId == roleId &&
                    rp.ModuleId == moduleId &&
                    rp.SubModuleId == subModuleId)
                .ToList();
        }
        public async Task<RolePermissionV2ViewModel> GetRolePermissionViewModelAsync()
        {
            var viewModel = new RolePermissionV2ViewModel
            {
                Modules = (await _context.GetRepository<Module>().GetAllAsync()).ToList(),
                Roles = (await _context.GetRepository<IdentityRole>().GetAllAsync()).ToList(),
                PermissionTypes = (await _context.GetRepository<PermissionTyepe>().GetAllAsync()).ToList(),
                Pages = new List<Page>(), 
                SubModules = new List<SubModule>() 
            };

            return viewModel;
        }

        public async Task<List<SubModule>> GetSubModulesByModuleIdAsync(int moduleId)
        {
            var allSubModules = await _context.GetRepository<SubModule>().GetAllAsync();

            var filteredSubModules = allSubModules
                .Where(sm => sm.ModuleId == moduleId)
                .Select(sm => new SubModule
                {
                    Id = sm.Id,
                    Name = sm.NameEn,
                    ModuleId = sm.ModuleId
                })
                .ToList();

            return filteredSubModules;
        }

        public async Task<List<Page>> GetPagesBySubModuleIdAsync(int subModuleId)
        {
            var allPages = await _context.GetRepository<Page>().GetAllAsync();

            var filteredPages = allPages
                .Where(p => p.SubmoduleId == subModuleId)
                .Select(p => new Page
                {
                    Id = p.Id,
                    Name = p.NameEn,
                    SubmoduleId = p.SubmoduleId
                })
                .ToList();

            return filteredPages;
        }

        public async Task SaveRolePermissionAsync(RolePermissionV2ViewModel model)
        {
            if (model == null || model.PageIds == null || model.PermissionIds == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            var allRolePermissions = await _context.GetRepository<RolePermission>().GetAllAsync();

            var permissionsToRemove = allRolePermissions
                .Where(rp =>
                    rp.RoleId == model.RoleId &&
                    rp.ModuleId == model.ModuleId &&
                    rp.SubModuleId == model.SubModuleId &&
                    !model.PageIds.Contains(rp.PageId) || !model.PermissionIds.Contains(rp.PermissionId))
                .ToList();

            foreach (var permission in permissionsToRemove)
            {
                await _context.GetRepository<RolePermission>().RemoveAsync(permission);
            }

            // Add new permissions
            foreach (var pageId in model.PageIds)
            {
                foreach (var permissionId in model.PermissionIds)
                {
                    var existingPermission = allRolePermissions
                        .FirstOrDefault(rp =>
                            rp.RoleId == model.RoleId &&
                            rp.ModuleId == model.ModuleId &&
                            rp.SubModuleId == model.SubModuleId &&
                            rp.PageId == pageId &&
                            rp.PermissionId == permissionId);

                    if (existingPermission == null)
                    {
                        var rolePermission = new RolePermission
                        {
                            RoleId = model.RoleId,
                            PermissionId = permissionId,
                            ModuleId = model.ModuleId,
                            SubModuleId = model.SubModuleId,
                            PageId = pageId
                        };

                        await _context.GetRepository<RolePermission>().AddAsync(rolePermission);
                    }
                }
            }

            await _context.SaveChangesAsync();
            
            var roleUser = await _context.GetRepository<IdentityUserRole<string>>()
                .GetFirstOrDefaultAsync(ur => ur.RoleId == model.RoleId);
            var userId = string.Empty;
            if (roleUser != null)
            {
                userId = roleUser.UserId;
            }
            
            var moduleService = new ModuleService(_context, _memoryCache);
            moduleService.InvalidateCacheForUser(userId);

        }
        public async Task<bool> CheckUserPermission(ClaimsPrincipal user, int pageId, int permissionId)
        {
            var userRoleNames = user.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value)
                .ToList();

            var roleIds = (await _context.GetRepository<IdentityRole>()
                .GetAllAsync(r => userRoleNames.Contains(r.Name)))
                .Select(r => r.Id)
                .ToList();

            var hasPermission = (await _context.GetRepository<RolePermission>()
                .GetAllAsync(rp => roleIds.Contains(rp.RoleId) && rp.PageId == pageId && rp.PermissionId == permissionId))
                .Any();

            return hasPermission;
        }
        public async Task<int?> GetPageIdByControllerAction(string controllerName, string actionName)
        {
            var pages = await _context.GetRepository<Page>()
                .GetAllAsync(p => p.Controller == controllerName && p.Action == actionName);

            var page = pages.FirstOrDefault();

            return page?.Id;
        }
    }
}