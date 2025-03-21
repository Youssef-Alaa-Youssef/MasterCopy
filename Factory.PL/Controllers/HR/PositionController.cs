using Factory.BLL.InterFaces;
using Factory.DAL.Models.HR;
using Factory.PL.ViewModels.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.PL.Controllers.HR
{
    public class PositionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<PositionController> _localizer;

        public PositionController(IUnitOfWork unitOfWork, IStringLocalizer<PositionController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var positions = await _unitOfWork.GetRepository<Position>().GetAllAsync();
            return View(positions);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var position = await _unitOfWork.GetRepository<Position>().GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"].Value;
            return View(position);
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"].Value;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(PositionViewModel positionViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var position = new Position
                {
                    Title = positionViewModel.Title,
                    TitleEn = positionViewModel.TitleEn,
                    Code = positionViewModel.Code,
                    Description = positionViewModel.Description,
                    DepartmentId = positionViewModel.DepartmentId,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<Position>().AddAsync(position);
                    TempData["Success"] = _localizer["PositionCreatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PositionCreationError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"].Value;
            return View(positionViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var position = await _unitOfWork.GetRepository<Position>().GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            var positionViewModel = new PositionViewModel
            {
                Id = position.Id,
                Title = position.Title,
                TitleEn = position.TitleEn,
                Code = position.Code,
                Description = position.Description,
                DepartmentId = position.DepartmentId
            };

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(positionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, PositionViewModel positionViewModel)
        {
            if (id != positionViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var position = await _unitOfWork.GetRepository<Position>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (position == null)
                {
                    return NotFound();
                }

                position.Title = positionViewModel.Title;
                position.TitleEn = positionViewModel.TitleEn;
                position.Code = positionViewModel.Code;
                position.Description = positionViewModel.Description;
                position.DepartmentId = positionViewModel.DepartmentId;
                position.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<Position>().UpdateAsync(position);
                    TempData["Success"] = _localizer["PositionUpdatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PositionUpdateError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(positionViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Delete(int id)
        {
            var position = await _unitOfWork.GetRepository<Position>().GetByIdAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"].Value;
            return View(position);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var position = await _unitOfWork.GetRepository<Position>().GetByIdAsync(id);
            if (position != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Position>().RemoveAsync(position);
                    TempData["Success"] = _localizer["PositionDeletedSuccessfully"].Value;
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PositionDeletionError", ex.Message].Value;
                }
            }
            else
            {
                TempData["Error"] = _localizer["PositionNotFound"].Value;
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownLists()
        {
            var departments = await _unitOfWork.GetRepository<Department>().GetAllAsync();
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
        }
    }
}