using Factory.BLL.InterFaces;
using Factory.DAL.Models.HR;
using Factory.PL.ViewModels.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Factory.PL.Controllers.HR
{
    public class OffboardingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<OffboardingController> _localizer;

        public OffboardingController(IUnitOfWork unitOfWork, IStringLocalizer<OffboardingController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var offboardings = await _unitOfWork.GetRepository<Offboarding>().GetAllAsync();

            var terminationReasonCounts = offboardings
                .GroupBy(o => o.TerminationReason)
                .Select(g => new
                {
                    Reason = g.Key,
                    Count = g.Count()
                })
                .ToList();

            ViewBag.TerminationReasons = terminationReasonCounts.Select(tr => tr.Reason).ToList();
            ViewBag.TerminationCounts = terminationReasonCounts.Select(tr => tr.Count).ToList();

            return View(offboardings);
        }
        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var offboarding = await _unitOfWork.GetRepository<Offboarding>().GetByIdAsync(id);
            if (offboarding == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"].Value;
            return View(offboarding);
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
        public async Task<IActionResult> Create(OffboardingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var offboarding = new Offboarding
                {
                    EmployeeId = viewModel.EmployeeId,
                    LastWorkingDate = viewModel.LastWorkingDate,
                    ExitInterviewDate = viewModel.ExitInterviewDate,
                    TerminationReason = viewModel.TerminationReason,
                    Status = viewModel.Status,
                    SupervisorId = viewModel.SupervisorId,
                    NoticeGivenDate = viewModel.NoticeGivenDate,
                    ReturnOfCompanyPropertyCompleted = viewModel.ReturnOfCompanyPropertyCompleted,
                    AccessRevocationCompleted = viewModel.AccessRevocationCompleted,
                    KnowledgeTransferCompleted = viewModel.KnowledgeTransferCompleted,
                    ExitInterviewCompleted = viewModel.ExitInterviewCompleted,
                    FinalPaymentCompleted = viewModel.FinalPaymentCompleted,
                    BenefitsTerminationCompleted = viewModel.BenefitsTerminationCompleted,
                    ReferenceArrangementCompleted = viewModel.ReferenceArrangementCompleted,
                    FarewellEventCompleted = viewModel.FarewellEventCompleted,
                    FeedbackProvided = viewModel.FeedbackProvided,
                    Notes = viewModel.Notes,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<Offboarding>().AddAsync(offboarding);
                    TempData["Success"] = _localizer["OffboardingCreatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OffboardingCreationError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"].Value;
            return View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var offboarding = await _unitOfWork.GetRepository<Offboarding>().GetByIdAsync(id);
            if (offboarding == null)
            {
                return NotFound();
            }

            var viewModel = new OffboardingViewModel
            {
                Id = offboarding.Id,
                EmployeeId = offboarding.EmployeeId,
                LastWorkingDate = offboarding.LastWorkingDate,
                ExitInterviewDate = offboarding.ExitInterviewDate,
                TerminationReason = offboarding.TerminationReason,
                Status = offboarding.Status,
                SupervisorId = offboarding.SupervisorId,
                NoticeGivenDate = offboarding.NoticeGivenDate,
                ReturnOfCompanyPropertyCompleted = offboarding.ReturnOfCompanyPropertyCompleted,
                AccessRevocationCompleted = offboarding.AccessRevocationCompleted,
                KnowledgeTransferCompleted = offboarding.KnowledgeTransferCompleted,
                ExitInterviewCompleted = offboarding.ExitInterviewCompleted,
                FinalPaymentCompleted = offboarding.FinalPaymentCompleted,
                BenefitsTerminationCompleted = offboarding.BenefitsTerminationCompleted,
                ReferenceArrangementCompleted = offboarding.ReferenceArrangementCompleted,
                FarewellEventCompleted = offboarding.FarewellEventCompleted,
                FeedbackProvided = offboarding.FeedbackProvided,
                Notes = offboarding.Notes
            };

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, OffboardingViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var offboarding = await _unitOfWork.GetRepository<Offboarding>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (offboarding == null)
                {
                    return NotFound();
                }

                offboarding.EmployeeId = viewModel.EmployeeId;
                offboarding.LastWorkingDate = viewModel.LastWorkingDate;
                offboarding.ExitInterviewDate = viewModel.ExitInterviewDate;
                offboarding.TerminationReason = viewModel.TerminationReason;
                offboarding.Status = viewModel.Status;
                offboarding.SupervisorId = viewModel.SupervisorId;
                offboarding.NoticeGivenDate = viewModel.NoticeGivenDate;
                offboarding.ReturnOfCompanyPropertyCompleted = viewModel.ReturnOfCompanyPropertyCompleted;
                offboarding.AccessRevocationCompleted = viewModel.AccessRevocationCompleted;
                offboarding.KnowledgeTransferCompleted = viewModel.KnowledgeTransferCompleted;
                offboarding.ExitInterviewCompleted = viewModel.ExitInterviewCompleted;
                offboarding.FinalPaymentCompleted = viewModel.FinalPaymentCompleted;
                offboarding.BenefitsTerminationCompleted = viewModel.BenefitsTerminationCompleted;
                offboarding.ReferenceArrangementCompleted = viewModel.ReferenceArrangementCompleted;
                offboarding.FarewellEventCompleted = viewModel.FarewellEventCompleted;
                offboarding.FeedbackProvided = viewModel.FeedbackProvided;
                offboarding.Notes = viewModel.Notes;
                offboarding.UserId = userId ?? string.Empty;

                UpdateOffboardingStatus(offboarding);

                try
                {
                    await _unitOfWork.GetRepository<Offboarding>().UpdateAsync(offboarding);
                    TempData["Success"] = _localizer["OffboardingUpdatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OffboardingUpdateError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var offboarding = await _unitOfWork.GetRepository<Offboarding>().GetByIdAsync(id);
            if (offboarding == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"].Value;
            return View(offboarding);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offboarding = await _unitOfWork.GetRepository<Offboarding>().GetByIdAsync(id);
            if (offboarding != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Offboarding>().RemoveAsync(offboarding);
                    TempData["Success"] = _localizer["OffboardingDeletedSuccessfully"].Value;
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OffboardingDeletionError", ex.Message].Value;
                }
            }
            else
            {
                TempData["Error"] = _localizer["OffboardingNotFound"].Value;
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownLists()
        {
            var employees = await _unitOfWork.GetRepository<Employee>().GetAllAsync();
            var supervisors = await _unitOfWork.GetRepository<Supervisor>().GetAllAsync();

            ViewBag.EmployeeList = new SelectList(employees, "Id", "FullName");
            ViewBag.SupervisorList = new SelectList(supervisors, "Id", "FullName");
        }

        private void UpdateOffboardingStatus(Offboarding offboarding)
        {
            var completedTasks = 0;
            var totalTasks = 10;

            if (offboarding.ReturnOfCompanyPropertyCompleted) completedTasks++;
            if (offboarding.AccessRevocationCompleted) completedTasks++;
            if (offboarding.KnowledgeTransferCompleted) completedTasks++;
            if (offboarding.ExitInterviewCompleted) completedTasks++;
            if (offboarding.FinalPaymentCompleted) completedTasks++;
            if (offboarding.BenefitsTerminationCompleted) completedTasks++;
            if (offboarding.ReferenceArrangementCompleted) completedTasks++;
            if (offboarding.FarewellEventCompleted) completedTasks++;
            if (offboarding.FeedbackProvided) completedTasks++;

            var completionPercentage = (completedTasks / (double)totalTasks) * 100;

            if (completionPercentage == 100)
            {
                offboarding.Status = "Completed";
            }
            else if (completionPercentage >= 80)
            {
                offboarding.Status = "Nearly Completed";
            }
            else
            {
                offboarding.Status = "In Progress";
            }
        }
    }
}