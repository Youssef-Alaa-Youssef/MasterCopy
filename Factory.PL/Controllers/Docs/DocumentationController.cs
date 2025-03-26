using Factory.BLL.InterFaces;
using Factory.DAL.Models.Documentation;
using Factory.PL.ViewModels.Documentation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.Controllers
{
    public class DocumentationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<DocumentationController> _localizer;

        public DocumentationController(
            IUnitOfWork unitOfWork,
            IStringLocalizer<DocumentationController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetAllAsync();
            ViewData["Title"] = _localizer["DocumentationIndexTitle"].ToString();
            ViewData["PageHeader"] = _localizer["AllDocumentation"].ToString();
            return View(documentation);
        }

        [Authorize]
        public async Task<IActionResult> Help()
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetAllAsync();
            ViewData["Title"] = _localizer["HelpPageTitle"].ToString();
            ViewData["PageHeader"] = _localizer["HelpResources"].ToString();
            return View(documentation);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetByIdAsync(id);
            if (documentation == null)
            {
                TempData["Error"] = _localizer["DocumentNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Title"] = _localizer["DetailsTitle"].ToString();
            return View(documentation);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewData["Title"] = _localizer["CreateDocumentTitle"].ToString();
            ViewData["PageHeader"] = _localizer["CreateNewDocument"].ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DocumentationViewModel documentationViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var documentation = new Documentation
                {
                    Title = documentationViewModel.Title,
                    Description = documentationViewModel.Description,
                    DescriptionEn = documentationViewModel.DescriptionEn,
                    Content = documentationViewModel.Content,
                    VideoUrl = documentationViewModel.VideoUrl,
                    CreatedAt = DateTime.UtcNow,
                    UserId = userId ?? string.Empty
                };

                try
                {
                    await _unitOfWork.GetRepository<Documentation>().AddAsync(documentation);
                    TempData["Success"] = _localizer["DocumentCreatedSuccess"].ToString();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DocumentCreateError", ex.Message].ToString();
                }
            }

            ViewData["Title"] = _localizer["CreateDocumentTitle"].ToString();
            return View(documentationViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetByIdAsync(id);
            if (documentation == null)
            {
                TempData["Error"] = _localizer["DocumentNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            var documentationViewModel = new DocumentationViewModel
            {
                Id = documentation.Id,
                Title = documentation.Title,
                Description = documentation.Description,
                Content = documentation.Content,
                VideoUrl = documentation.VideoUrl
            };

            ViewData["Title"] = _localizer["EditDocumentTitle"].ToString();
            ViewData["PageHeader"] = _localizer["EditDocument"].ToString();
            return View(documentationViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, DocumentationViewModel documentationViewModel)
        {
            if (id != documentationViewModel.Id)
            {
                TempData["Error"] = _localizer["DocumentIdMismatch"].ToString();
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                var documentation = await _unitOfWork.GetRepository<Documentation>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (documentation == null)
                {
                    TempData["Error"] = _localizer["DocumentNotFound"].ToString();
                    return RedirectToAction(nameof(Index));
                }

                documentation.Title = documentationViewModel.Title;
                documentation.Description = documentationViewModel.Description;
                documentation.Content = documentationViewModel.Content;
                documentation.VideoUrl = documentationViewModel.VideoUrl;
                documentation.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<Documentation>().UpdateAsync(documentation);
                    TempData["Success"] = _localizer["DocumentUpdatedSuccess"].ToString();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DocumentUpdateError", ex.Message].ToString();
                }
            }

            ViewData["Title"] = _localizer["EditDocumentTitle"].ToString();
            return View(documentationViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Delete(int id)
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetByIdAsync(id);
            if (documentation == null)
            {
                TempData["Error"] = _localizer["DocumentNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Title"] = _localizer["DeleteDocumentTitle"].ToString();
            return View(documentation);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var documentation = await _unitOfWork.GetRepository<Documentation>().GetByIdAsync(id);
            if (documentation != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<Documentation>().RemoveAsync(documentation);
                    TempData["Success"] = _localizer["DocumentDeletedSuccess"].ToString();
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["DocumentDeleteError", ex.Message].ToString();
                }
            }
            else
            {
                TempData["Error"] = _localizer["DocumentNotFound"].ToString();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}