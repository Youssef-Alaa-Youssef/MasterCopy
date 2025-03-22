using Microsoft.AspNetCore.Mvc;
using Factory.DAL.Services;
using Factory.DAL.ViewModels.Permissions;

namespace Factory.PL.Controllers.Permission
{
    public class AssignPermissionController : Controller
    {
        private readonly RolePermissionService _rolePermissionService;

        public AssignPermissionController(RolePermissionService rolePermissionService)
        {
            _rolePermissionService = rolePermissionService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await _rolePermissionService.GetRolePermissionViewModelAsync();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GetSubModules(int moduleId)
        {
            var subModules = await _rolePermissionService.GetSubModulesByModuleIdAsync(moduleId);
            return Json(subModules);
        }

        [HttpPost]
        public async Task<IActionResult> GetPages(int subModuleId)
        {
            var pages = await _rolePermissionService.GetPagesBySubModuleIdAsync(subModuleId);
            return Json(pages);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRolePermission(RolePermissionV2ViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _rolePermissionService.SaveRolePermissionAsync(model);
                TempData["Message"] = "Permission assigned successfully!";
                return RedirectToAction("Index");
            }

            var viewModel = await _rolePermissionService.GetRolePermissionViewModelAsync();
            return View("Index", viewModel);
        }
    }
}