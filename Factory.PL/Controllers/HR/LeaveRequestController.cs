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
    public class LeaveRequestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<LeaveRequestController> _localizer;

        public LeaveRequestController(IUnitOfWork unitOfWork, IStringLocalizer<LeaveRequestController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var leaveRequests = await _unitOfWork.GetRepository<LeaveRequest>().GetAllAsync();
            return View(leaveRequests);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var leaveRequest = await _unitOfWork.GetRepository<LeaveRequest>().GetByIdAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"];
            return View(leaveRequest);
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(LeaveRequestViewModel leaveRequestViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var leaveRequest = new LeaveRequest
                {
                    EmployeeId = leaveRequestViewModel.EmployeeId,
                    StartDate = leaveRequestViewModel.StartDate,
                    EndDate = leaveRequestViewModel.EndDate,
                    TotalDays = (leaveRequestViewModel.EndDate - leaveRequestViewModel.StartDate).Days + 1,
                    Type = leaveRequestViewModel.Type,
                    Reason = leaveRequestViewModel.Reason,
                    Status = leaveRequestViewModel.Status,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<LeaveRequest>().AddAsync(leaveRequest);
                    TempData["Success"] = _localizer["LeaveRequestCreatedSuccessfully"];
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["LeaveRequestCreationError", ex.Message];
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"];
            return View(leaveRequestViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var leaveRequest = await _unitOfWork.GetRepository<LeaveRequest>().GetByIdAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            var leaveRequestViewModel = new LeaveRequestViewModel
            {
                Id = leaveRequest.Id,
                EmployeeId = leaveRequest.EmployeeId,
                StartDate = leaveRequest.StartDate,
                EndDate = leaveRequest.EndDate,
                TotalDays = leaveRequest.TotalDays,
                Type = leaveRequest.Type,
                Reason = leaveRequest.Reason,
                Status = leaveRequest.Status,
                ApprovedById = leaveRequest.ApprovedById,
                ApprovedDate = leaveRequest.ApprovedDate,
                RejectionReason = leaveRequest.RejectionReason
            };

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"];
            return View(leaveRequestViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, LeaveRequestViewModel leaveRequestViewModel)
        {
            if (id != leaveRequestViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var leaveRequest = await _unitOfWork.GetRepository<LeaveRequest>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (leaveRequest == null)
                {
                    return NotFound();
                }

                leaveRequest.EmployeeId = leaveRequestViewModel.EmployeeId;
                leaveRequest.StartDate = leaveRequestViewModel.StartDate;
                leaveRequest.EndDate = leaveRequestViewModel.EndDate;
                leaveRequest.TotalDays = (leaveRequestViewModel.EndDate - leaveRequestViewModel.StartDate).Days + 1;
                leaveRequest.Type = leaveRequestViewModel.Type;
                leaveRequest.Reason = leaveRequestViewModel.Reason;
                leaveRequest.Status = leaveRequestViewModel.Status;
                leaveRequest.ApprovedById = leaveRequestViewModel.ApprovedById;
                leaveRequest.ApprovedDate = leaveRequestViewModel.ApprovedDate;
                leaveRequest.RejectionReason = leaveRequestViewModel.RejectionReason;
                leaveRequest.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<LeaveRequest>().UpdateAsync(leaveRequest);
                    TempData["Success"] = _localizer["LeaveRequestUpdatedSuccessfully"];
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["LeaveRequestUpdateError", ex.Message];
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"];
            return View(leaveRequestViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Delete(int id)
        {
            var leaveRequest = await _unitOfWork.GetRepository<LeaveRequest>().GetByIdAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"];
            return View(leaveRequest);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveRequest = await _unitOfWork.GetRepository<LeaveRequest>().GetByIdAsync(id);
            if (leaveRequest != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<LeaveRequest>().RemoveAsync(leaveRequest);
                    TempData["Success"] = _localizer["LeaveRequestDeletedSuccessfully"];
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["LeaveRequestDeletionError", ex.Message];
                }
            }
            else
            {
                TempData["Error"] = _localizer["LeaveRequestNotFound"];
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownLists()
        {
            var employees = await _unitOfWork.GetRepository<Employee>().GetAllAsync();
            ViewBag.Employees = new SelectList(employees, "Id", "FullName");
        }
    }
}