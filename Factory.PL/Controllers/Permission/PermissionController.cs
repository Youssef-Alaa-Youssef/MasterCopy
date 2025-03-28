using Factory.BLL.InterFaces;
using Factory.DAL.Enums;
using Factory.DAL.Models.Permission;
using Factory.PL.ViewModels.Permission;
using Factory.PL.ViewModels.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Factory.Web.Controllers
{
    [Authorize(Roles = nameof(UserRole.MasterCopy))]
    public class PermissionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;

        public PermissionController(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var viewModel = new RolePermissionViewModel
            {
                Roles = roles.Select(r => new SelectListItem
                {
                    Value = r.Id,
                    Text = r.Name
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetModules()
        {
            var modules = (await _unitOfWork.GetRepository<Module>()
                .GetAllAsync())
                .Where(m => m.IsActive)
                .Select(m => new ModuleViewModel
                {
                    ModuleId = m.Id,
                    ModuleName = m.Name
                })
                .ToList();

            return Json(new ModuleListViewModel { Modules = modules });
        }

        [HttpGet]
        public async Task<IActionResult> GetSubModules(int moduleId)
        {
            var subModules = (await _unitOfWork.GetRepository<SubModule>()
                .GetAllAsync())
                .Where(sm => sm.ModuleId == moduleId)
                .Select(sm => new SubModuleViewModel
                {
                    SubModuleId = sm.Id,
                    SubModuleName = sm.Name
                })
                .ToList();

            return Json(new SubModuleListViewModel { SubModules = subModules });
        }

        [HttpGet]
        public async Task<IActionResult> GetPages(int subModuleId)
        {
            var pages = (await _unitOfWork.GetRepository<Page>()
                .GetAllAsync())
                .Where(p => p.SubmoduleId == subModuleId && p.IsActive)
                .Select(p => new PageViewModel
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

            return Json(new PageListViewModel { Pages = pages });
        }

        [HttpGet]
        public async Task<IActionResult> GetPermissionTypes(int pageId)
        {
            var permissionTypes = (await _unitOfWork.GetRepository<PermissionTyepe>()
                .GetAllAsync())
                .Select(pt => new PermissionTypeViewModel
                {
                    PermissionId = pt.Id,
                    PermissionName = pt.Name,
                    IsGranted = false
                })
                .ToList();

            return Json(permissionTypes);
        }

        [HttpGet]
        public async Task<IActionResult> GetRolePermissions(string roleId)
        {
            if (string.IsNullOrEmpty(roleId))
            {
                return BadRequest("Role ID is required");
            }

            var rolePermissions = (await _unitOfWork.GetRepository<RolePermission>()
                .GetAllAsync())
                .Where(rp => rp.RoleId == roleId)
                .ToList();

            var modules = (await _unitOfWork.GetRepository<Module>()
                .GetAllAsync())
                .Where(m => m.IsActive)
                .ToList();

            var permissionTypes = (await _unitOfWork.GetRepository<PermissionTyepe>()
                .GetAllAsync())
                .ToList();

            var viewModel = new RolePermissionViewModel
            {
                RoleId = roleId,
                Modules = modules.Select(m => new ModulePermissionViewModel
                {
                    ModuleId = m.Id,
                    ModuleName = m.Name,
                    IsSelected = rolePermissions.Any(rp => rp.ModuleId == m.Id),
                    SubModules = m.SubModules.Select(sm => new SubModulePermissionViewModel
                    {
                        SubModuleId = sm.Id,
                        SubModuleName = sm.Name,
                        IsSelected = false, 
                        Pages = sm.Pages.Select(p => new PagePermissionViewModel
                        {
                            PageId = p.Id,
                            PageName = p.Name,
                            IsSelected = false, 
                            Permissions = permissionTypes.Select(pt => new PermissionTypeViewModel
                            {
                                PermissionId = pt.Id,
                                PermissionName = pt.Name,
                                IsGranted = rolePermissions.Any(rp =>
                                    rp.ModuleId == m.Id &&
                                    rp.Permission.Id == pt.Id)
                            }).ToList()
                        }).ToList()
                    }).ToList()
                }).ToList()
            };

            return Json(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRolePermissions([FromBody] PermissionAssignmentViewModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.RoleId))
            {
                return BadRequest("Invalid data");
            }

            // Log or inspect model data
            Console.WriteLine($"Received RoleId: {model.RoleId}");
            foreach (var permission in model.Permissions)
            {
                Console.WriteLine($"PermissionId: {permission.PermissionId}, IsGranted: {permission.IsGranted}");
            }

            // Your existing logic
            try
            {
                var executionStrategy = _unitOfWork.CreateExecutionStrategy();
                await executionStrategy.ExecuteAsync(async () =>
                {
                    await _unitOfWork.BeginTransactionAsync();

                    // Remove existing permissions
                    var existingPermissions = (await _unitOfWork.GetRepository<RolePermission>()
                        .GetAllAsync())
                        .AsQueryable()
                        .AsNoTracking()
                        .Where(rp => rp.RoleId == model.RoleId)
                        .ToList();

                    foreach (var permission in existingPermissions)
                    {
                        await _unitOfWork.GetRepository<RolePermission>().RemoveAsync(permission);
                    }

                    // Add new permissions
                    foreach (var permission in model.Permissions.Where(p => p.IsGranted))
                    {
                        var rolePermission = new RolePermission
                        {
                            RoleId = model.RoleId,
                            ModuleId = permission.ModuleId,
                            PermissionId = permission.PermissionId
                        };

                        await _unitOfWork.GetRepository<RolePermission>().AddAsync(rolePermission);
                    }

                    await _unitOfWork.SaveChangesAsync();
                    await _unitOfWork.CommitTransactionAsync();
                });

                return Ok(new { success = true, message = "Permissions saved successfully" });
            }
            catch (Exception ex)
            {
                await _unitOfWork.RollbackTransactionAsync();
                return StatusCode(500, new { success = false, message = "An error occurred while saving permissions", error = ex.Message });
            }
        }

    }
}