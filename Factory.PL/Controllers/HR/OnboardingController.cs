using Factory.BLL.InterFaces;
using Factory.DAL.Enums.HR;
using Factory.DAL.Models.HR;
using Factory.PL.ViewModels.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.PL.Controllers.HR
{
    public class OnboardingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<OnboardingController> _localizer;

        public OnboardingController(IUnitOfWork unitOfWork, IStringLocalizer<OnboardingController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var onboardings = await _unitOfWork.GetRepository<Onboarding>().GetAllAsync();

            var notStartedCount = onboardings.Count(o => o.Status == OnboardingStatus.NotStarted);
            var inProgressCount = onboardings.Count(o => o.Status == OnboardingStatus.InProgress);
            var completedCount = onboardings.Count(o => o.Status == OnboardingStatus.Completed);

            ViewBag.NotStartedCount = notStartedCount;
            ViewBag.InProgressCount = inProgressCount;
            ViewBag.CompletedCount = completedCount;

            return View(onboardings);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var onboarding = await _unitOfWork.GetRepository<Onboarding>().GetByIdAsync(id);
            if (onboarding == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"].Value;
            return View(onboarding);
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
        public async Task<IActionResult> Create(OnboardingViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var onboarding = new Onboarding
                {
                    EmployeeId = viewModel.EmployeeId,
                    StartDate = viewModel.StartDate,
                    ExpectedCompletionDate = viewModel.ExpectedCompletionDate,
                    ActualCompletionDate = viewModel.ActualCompletionDate,
                    Status = viewModel.Status,
                    SupervisorId = viewModel.SupervisorId,
                    OrientationCompleted = viewModel.OrientationCompleted,
                    WorkspaceSetupCompleted = viewModel.WorkspaceSetupCompleted,
                    EquipmentProvidedCompleted = viewModel.EquipmentProvidedCompleted,
                    SystemAccessCompleted = viewModel.SystemAccessCompleted,
                    TrainingCompleted = viewModel.TrainingCompleted,
                    IntroductionToTeamCompleted = viewModel.IntroductionToTeamCompleted,
                    PoliciesReviewedCompleted = viewModel.PoliciesReviewedCompleted,
                    FirstAssignmentCompleted = viewModel.FirstAssignmentCompleted,
                    FeedbackSessionCompleted = viewModel.FeedbackSessionCompleted,
                    Notes = viewModel.Notes,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<Onboarding>().AddAsync(onboarding);
                    TempData["Success"] = _localizer["OnboardingCreatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OnboardingCreationError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"].Value;
            return View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var onboarding = await _unitOfWork.GetRepository<Onboarding>().GetByIdAsync(id);
            if (onboarding == null)
            {
                return NotFound();
            }

            var viewModel = new OnboardingViewModel
            {
                Id = onboarding.Id,
                EmployeeId = onboarding.EmployeeId,
                StartDate = onboarding.StartDate,
                ExpectedCompletionDate = onboarding.ExpectedCompletionDate,
                ActualCompletionDate = onboarding.ActualCompletionDate,
                Status = onboarding.Status,
                SupervisorId = onboarding.SupervisorId,
                OrientationCompleted = onboarding.OrientationCompleted,
                WorkspaceSetupCompleted = onboarding.WorkspaceSetupCompleted,
                EquipmentProvidedCompleted = onboarding.EquipmentProvidedCompleted,
                SystemAccessCompleted = onboarding.SystemAccessCompleted,
                TrainingCompleted = onboarding.TrainingCompleted,
                IntroductionToTeamCompleted = onboarding.IntroductionToTeamCompleted,
                PoliciesReviewedCompleted = onboarding.PoliciesReviewedCompleted,
                FirstAssignmentCompleted = onboarding.FirstAssignmentCompleted,
                FeedbackSessionCompleted = onboarding.FeedbackSessionCompleted,
                Notes = onboarding.Notes
            };

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, OnboardingViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var onboarding = await _unitOfWork.GetRepository<Onboarding>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (onboarding == null)
                {
                    return NotFound();
                }

                onboarding.EmployeeId = viewModel.EmployeeId;
                onboarding.StartDate = viewModel.StartDate;
                onboarding.ExpectedCompletionDate = viewModel.ExpectedCompletionDate;
                onboarding.ActualCompletionDate = viewModel.ActualCompletionDate;
                onboarding.Status = viewModel.Status;
                onboarding.SupervisorId = viewModel.SupervisorId;
                onboarding.OrientationCompleted = viewModel.OrientationCompleted;
                onboarding.WorkspaceSetupCompleted = viewModel.WorkspaceSetupCompleted;
                onboarding.EquipmentProvidedCompleted = viewModel.EquipmentProvidedCompleted;
                onboarding.SystemAccessCompleted = viewModel.SystemAccessCompleted;
                onboarding.TrainingCompleted = viewModel.TrainingCompleted;
                onboarding.IntroductionToTeamCompleted = viewModel.IntroductionToTeamCompleted;
                onboarding.PoliciesReviewedCompleted = viewModel.PoliciesReviewedCompleted;
                onboarding.FirstAssignmentCompleted = viewModel.FirstAssignmentCompleted;
                onboarding.FeedbackSessionCompleted = viewModel.FeedbackSessionCompleted;
                onboarding.Notes = viewModel.Notes;
                onboarding.UserId = userId ?? string.Empty;

                // Update onboarding status based on completion rate
                UpdateOnboardingStatus(onboarding);

                try
                {
                    await _unitOfWork.GetRepository<Onboarding>().UpdateAsync(onboarding);
                    TempData["Success"] = _localizer["OnboardingUpdatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OnboardingUpdateError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var onboarding = await _unitOfWork.GetRepository<Onboarding>().GetByIdAsync(id);
            if (onboarding == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"].Value;
            return View(onboarding);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var onboarding = await _unitOfWork.GetRepository<Onboarding>().GetByIdAsync(id);
            if (onboarding != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Onboarding>().RemoveAsync(onboarding);
                    TempData["Success"] = _localizer["OnboardingDeletedSuccessfully"].Value;
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["OnboardingDeletionError", ex.Message].Value;
                }
            }
            else
            {
                TempData["Error"] = _localizer["OnboardingNotFound"].Value;
            }

            return RedirectToAction(nameof(Index));
        }

        private void UpdateOnboardingStatus(Onboarding onboarding)
        {
            // Count completed tasks
            int totalTasks = 9; // Total number of onboarding tasks
            int completedTasks = 0;

            if (onboarding.OrientationCompleted) completedTasks++;
            if (onboarding.WorkspaceSetupCompleted) completedTasks++;
            if (onboarding.EquipmentProvidedCompleted) completedTasks++;
            if (onboarding.SystemAccessCompleted) completedTasks++;
            if (onboarding.TrainingCompleted) completedTasks++;
            if (onboarding.IntroductionToTeamCompleted) completedTasks++;
            if (onboarding.PoliciesReviewedCompleted) completedTasks++;
            if (onboarding.FirstAssignmentCompleted) completedTasks++;
            if (onboarding.FeedbackSessionCompleted) completedTasks++;

            // Calculate completion percentage
            double completionPercentage = (double)completedTasks / totalTasks * 100;

            // Update status based on completion percentage
            if (completionPercentage == 0)
            {
                onboarding.Status = OnboardingStatus.NotStarted;
            }
            else if (completionPercentage < 100)
            {
                onboarding.Status = OnboardingStatus.InProgress;
            }
            else
            {
                onboarding.Status = OnboardingStatus.Completed;
                onboarding.ActualCompletionDate = DateTime.Now;
            }
        }

        private async Task PopulateDropdownLists()
        {
            var employees = await _unitOfWork.GetRepository<Employee>().GetAllAsync();
            ViewBag.Employees = new SelectList(employees, "Id", "FullName");

            ViewBag.Supervisors = new SelectList(employees, "Id", "FullName");

            ViewBag.OnboardingStatuses = new SelectList(Enum.GetValues(typeof(OnboardingStatus))
                .Cast<OnboardingStatus>()
                .Select(s => new { Value = (int)s, Text = s.ToString() }),
                "Value", "Text");
        }
    }
}