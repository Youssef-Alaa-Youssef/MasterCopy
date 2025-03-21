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
    public class PerformanceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<PerformanceController> _localizer;

        public PerformanceController(IUnitOfWork unitOfWork, IStringLocalizer<PerformanceController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var performances = await _unitOfWork.GetRepository<Performance>().GetAllAsync();

            var scoreCounts = performances
                .GroupBy(p => p.OverallScore)
                .Select(g => new
                {
                    Score = g.Key,
                    Count = g.Count()
                })
                .OrderBy(g => g.Score) 
                .ToList();

            ViewBag.Scores = scoreCounts.Select(sc => sc.Score.ToString()).ToList();
            ViewBag.ScoreCounts = scoreCounts.Select(sc => sc.Count).ToList();

            return View(performances);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var performance = await _unitOfWork.GetRepository<Performance>().GetByIdAsync(id);
            if (performance == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DetailsTitle"].Value;
            return View(performance);
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
        public async Task<IActionResult> Create(PerformanceViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var performance = new Performance
                {
                    EmployeeId = viewModel.EmployeeId,
                    ReviewDate = viewModel.ReviewDate,
                    ReviewPeriodStart = viewModel.ReviewPeriodStart,
                    ReviewPeriodEnd = viewModel.ReviewPeriodEnd,
                    ProductivityScore = viewModel.ProductivityScore,
                    QualityScore = viewModel.QualityScore,
                    TeamworkScore = viewModel.TeamworkScore,
                    CommunicationScore = viewModel.CommunicationScore,
                    InitiativeScore = viewModel.InitiativeScore,
                    OverallScore = CalculateOverallScore(viewModel),
                    ManagerFeedback = viewModel.ManagerFeedback,
                    EmployeeFeedback = viewModel.EmployeeFeedback,
                    GoalsForNextPeriod = viewModel.GoalsForNextPeriod,
                    DevelopmentPlan = viewModel.DevelopmentPlan,
                    ReviewStatus = ReviewStatus.Completed,
                    UserId = userId ?? string.Empty,
                    CreatedAt = DateTime.UtcNow
                };

                try
                {
                    await _unitOfWork.GetRepository<Performance>().AddAsync(performance);
                    TempData["Success"] = _localizer["PerformanceCreatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PerformanceCreationError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["CreateTitle"].Value;
            return View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var performance = await _unitOfWork.GetRepository<Performance>().GetByIdAsync(id);
            if (performance == null)
            {
                return NotFound();
            }

            var viewModel = new PerformanceViewModel
            {
                Id = performance.Id,
                EmployeeId = performance.EmployeeId,
                ReviewDate = performance.ReviewDate,
                ReviewPeriodStart = performance.ReviewPeriodStart,
                ReviewPeriodEnd = performance.ReviewPeriodEnd,
                ProductivityScore = performance.ProductivityScore,
                QualityScore = performance.QualityScore,
                TeamworkScore = performance.TeamworkScore,
                CommunicationScore = performance.CommunicationScore,
                InitiativeScore = performance.InitiativeScore,
                OverallScore = performance.OverallScore,
                ManagerFeedback = performance.ManagerFeedback,
                EmployeeFeedback = performance.EmployeeFeedback,
                GoalsForNextPeriod = performance.GoalsForNextPeriod,
                DevelopmentPlan = performance.DevelopmentPlan,
                ReviewStatus = performance.ReviewStatus
            };

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, PerformanceViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var performance = await _unitOfWork.GetRepository<Performance>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (performance == null)
                {
                    return NotFound();
                }

                performance.EmployeeId = viewModel.EmployeeId;
                performance.ReviewDate = viewModel.ReviewDate;
                performance.ReviewPeriodStart = viewModel.ReviewPeriodStart;
                performance.ReviewPeriodEnd = viewModel.ReviewPeriodEnd;
                performance.ProductivityScore = viewModel.ProductivityScore;
                performance.QualityScore = viewModel.QualityScore;
                performance.TeamworkScore = viewModel.TeamworkScore;
                performance.CommunicationScore = viewModel.CommunicationScore;
                performance.InitiativeScore = viewModel.InitiativeScore;
                performance.OverallScore = CalculateOverallScore(viewModel);
                performance.ManagerFeedback = viewModel.ManagerFeedback;
                performance.EmployeeFeedback = viewModel.EmployeeFeedback;
                performance.GoalsForNextPeriod = viewModel.GoalsForNextPeriod;
                performance.DevelopmentPlan = viewModel.DevelopmentPlan;
                performance.ReviewStatus = viewModel.ReviewStatus;
                performance.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<Performance>().UpdateAsync(performance);
                    TempData["Success"] = _localizer["PerformanceUpdatedSuccessfully"].Value;
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PerformanceUpdateError", ex.Message].Value;
                }
            }

            await PopulateDropdownLists();
            ViewData["Title"] = _localizer["EditTitle"].Value;
            return View(viewModel);
        }

        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var performance = await _unitOfWork.GetRepository<Performance>().GetByIdAsync(id);
            if (performance == null)
            {
                return NotFound();
            }

            ViewData["Title"] = _localizer["DeleteTitle"].Value;
            return View(performance);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var performance = await _unitOfWork.GetRepository<Performance>().GetByIdAsync(id);
            if (performance != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Performance>().RemoveAsync(performance);
                    TempData["Success"] = _localizer["PerformanceDeletedSuccessfully"].Value;
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["PerformanceDeletionError", ex.Message].Value;
                }
            }
            else
            {
                TempData["Error"] = _localizer["PerformanceNotFound"].Value;
            }

            return RedirectToAction(nameof(Index));
        }

        private decimal CalculateOverallScore(PerformanceViewModel viewModel)
        {
            return (viewModel.ProductivityScore +
                   viewModel.QualityScore +
                   viewModel.TeamworkScore +
                   viewModel.CommunicationScore +
                   viewModel.InitiativeScore) / 5.0m;
        }

        private async Task PopulateDropdownLists()
        {
            var employees = await _unitOfWork.GetRepository<Employee>().GetAllAsync();
            ViewBag.Employees = new SelectList(employees, "Id", "FullName");

            ViewBag.ReviewStatuses = new SelectList(Enum.GetValues(typeof(ReviewStatus))
                .Cast<ReviewStatus>()
                .Select(s => new { Value = (int)s, Text = s.ToString() }),
                "Value", "Text");
        }
    }
}