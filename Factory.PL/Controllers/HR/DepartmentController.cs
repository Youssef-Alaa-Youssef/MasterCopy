using Factory.BLL.InterFaces;
using Factory.DAL.Models.HR;
using Factory.PL.ViewModels.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.PL.Controllers.HR
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<DepartmentController> _localizer;

        public DepartmentController(IUnitOfWork unitOfWork, IStringLocalizer<DepartmentController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var departments = await _unitOfWork.GetRepository<Department>().GetAllAsync();
            return View(departments);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var department = await _unitOfWork.GetRepository<Department>().GetByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"];
            return View(department);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewData["Title"] = _localizer["CreateTitle"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(DepartmentViewModel departmentViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var department = new Department
                {
                    Name = departmentViewModel.Name,
                    NameEn = departmentViewModel.NameEn,
                    Code = departmentViewModel.Code,
                    Description = departmentViewModel.Description,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<Department>().AddAsync(department);
                    TempData["Success"] = _localizer["DepartmentCreatedSuccessfully"];
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DepartmentCreationError", ex.Message];
                }
            }

            ViewData["Title"] = _localizer["CreateTitle"];
            return View(departmentViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var department = await _unitOfWork.GetRepository<Department>().GetByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            var departmentViewModel = new DepartmentViewModel
            {
                Id = department.Id,
                Name = department.Name,
                NameEn = department.NameEn,
                Code = department.Code,
                Description = department.Description
            };

            ViewData["Title"] = _localizer["EditTitle"];
            return View(departmentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, DepartmentViewModel departmentViewModel)
        {
            if (id != departmentViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var department = await _unitOfWork.GetRepository<Department>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (department == null)
                {
                    return NotFound();
                }

                department.Name = departmentViewModel.Name;
                department.NameEn = departmentViewModel.NameEn;
                department.Code = departmentViewModel.Code;
                department.Description = departmentViewModel.Description;
                department.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<Department>().UpdateAsync(department);
                    TempData["Success"] = _localizer["DepartmentUpdatedSuccessfully"];
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DepartmentUpdateError", ex.Message];
                }
            }

            ViewData["Title"] = _localizer["EditTitle"];
            return View(departmentViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Delete(int id)
        {
            var department = await _unitOfWork.GetRepository<Department>().GetByIdAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"];
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await _unitOfWork.GetRepository<Department>().GetByIdAsync(id);
            if (department != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Department>().RemoveAsync(department);
                    TempData["Success"] = _localizer["DepartmentDeletedSuccessfully"];
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DepartmentDeletionError", ex.Message];
                }
            }
            else
            {
                TempData["Error"] = _localizer["DepartmentNotFound"];
            }

            return RedirectToAction(nameof(Index));
        }
    }
}