using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Factory.PL.ViewModels.Permissions;
using Microsoft.AspNetCore.Authorization;
using Factory.DAL.Enums;
using Factory.PL.Services.Permssions;

namespace Factory.PL.Controllers.Permission
{
    [Authorize(Roles = nameof(UserRole.MasterCopy))]
    public class AssignPermissionController : Controller
    {
        private readonly IRolePermissionService _rolePermissionService;
        private readonly JsonSerializerOptions _jsonOptions;

        public AssignPermissionController(IRolePermissionService rolePermissionService)
        {
            _rolePermissionService = rolePermissionService;

            _jsonOptions = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 64 
            };
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await _rolePermissionService.GetRolePermissionViewModelAsync();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetExistingPermissions(string roleId, int moduleId, int subModuleId)
        {
            if (string.IsNullOrEmpty(roleId) || moduleId <= 0 || subModuleId <= 0)
            {
                return Json(new List<object>());
            }

            var existingPermissions = await _rolePermissionService.GetExistingPermissionsAsync(roleId, moduleId, subModuleId);

            var groupedPermissions = existingPermissions
                .GroupBy(p => new { p.PageId, p.PermissionId })
                .Select(g => new
                {
                    pageId = g.Key.PageId,
                    permissionId = g.Key.PermissionId
                });

            return Json(groupedPermissions);
        }
        [HttpGet]
        public async Task<IActionResult> GetSubModules(int moduleId)
        {
            var subModules = await _rolePermissionService.GetSubModulesByModuleIdAsync(moduleId);

            var simplifiedSubModules = subModules.Select(sm => new
            {
                id = sm.Id,
                name = sm.NameEn
            });

            return Json(simplifiedSubModules);
        }

        [HttpGet]
        public async Task<IActionResult> GetPages(int subModuleId)
        {
            var pages = await _rolePermissionService.GetPagesBySubModuleIdAsync(subModuleId);

            var simplifiedPages = pages.Select(p => new
            {
                id = p.Id,
                name = p.Name
            });

            return Json(simplifiedPages);
        }


        [HttpPost]
        public async Task<IActionResult> SaveRolePermission(RolePermissionV2ViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _rolePermissionService.SaveRolePermissionAsync(model);
                TempData["Success"] = "Permissions have been successfully updated!";
                return RedirectToAction("Index", "PermissionManagement");
            }

            var viewModel = await _rolePermissionService.GetRolePermissionViewModelAsync();
            viewModel.ModuleId = model.ModuleId;
            viewModel.SubModuleId = model.SubModuleId;
            viewModel.PageIds = model.PageIds;
            viewModel.RoleId = model.RoleId;
            viewModel.PermissionIds = model.PermissionIds;
            TempData["Error"] = "Error, Please Try Again!";

            return View("Index", viewModel);
        }
    }
}