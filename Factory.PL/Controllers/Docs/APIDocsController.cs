using Factory.BLL.InterFaces;
using Factory.DAL.Models.Documentation;
using Factory.PL.ViewModels.Documentation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.Controllers.Docs
{
    public class APIDocsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<APIDocsController> _localizer;

        public APIDocsController(
            IUnitOfWork unitOfWork,
            IStringLocalizer<APIDocsController> localizer)
        {
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var apiDocs = await _unitOfWork.GetRepository<APIDoc>().GetAllAsync();
            ViewData["Title"] = _localizer["APIDocsIndexTitle"].ToString();
            ViewData["PageHeader"] = _localizer["AllAPIDocs"].ToString();
            return View(apiDocs);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var apiDoc = await _unitOfWork.GetRepository<APIDoc>().GetByIdAsync(id);
            if (apiDoc == null)
            {
                TempData["Error"] = _localizer["APIDocNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Title"] = _localizer["APIDocDetailsTitle"].ToString();
            return View(apiDoc);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewData["Title"] = _localizer["CreateAPIDocTitle"].ToString();
            ViewData["PageHeader"] = _localizer["CreateNewAPIDoc"].ToString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(APIDocViewModel apiDocViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var apiDoc = new APIDoc
                {
                    Title = apiDocViewModel.Title,
                    Description = apiDocViewModel.Description,
                    DescriptionEn = apiDocViewModel.DescriptionEn,
                    Endpoint = apiDocViewModel.Endpoint,
                    Method = apiDocViewModel.Method,
                    RequestExample = apiDocViewModel.RequestExample,
                    ResponseExample = apiDocViewModel.ResponseExample,
                    Parameters = apiDocViewModel.Parameters,
                    CreatedAt = DateTime.UtcNow,
                    UserId = userId ?? string.Empty
                };

                try
                {
                    await _unitOfWork.GetRepository<APIDoc>().AddAsync(apiDoc);
                    TempData["Success"] = _localizer["APIDocCreatedSuccess"].ToString();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["APIDocCreateError", ex.Message].ToString();
                }
            }

            ViewData["Title"] = _localizer["CreateAPIDocTitle"].ToString();
            return View(apiDocViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var apiDoc = await _unitOfWork.GetRepository<APIDoc>().GetByIdAsync(id);
            if (apiDoc == null)
            {
                TempData["Error"] = _localizer["APIDocNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            var apiDocViewModel = new APIDocViewModel
            {
                Id = apiDoc.Id,
                Title = apiDoc.Title,
                Description = apiDoc.Description,
                DescriptionEn = apiDoc.DescriptionEn,
                Endpoint = apiDoc.Endpoint,
                Method = apiDoc.Method,
                RequestExample = apiDoc.RequestExample,
                ResponseExample = apiDoc.ResponseExample,
                Parameters = apiDoc.Parameters
            };

            ViewData["Title"] = _localizer["EditAPIDocTitle"].ToString();
            ViewData["PageHeader"] = _localizer["EditAPIDoc"].ToString();
            return View(apiDocViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, APIDocViewModel apiDocViewModel)
        {
            if (id != apiDocViewModel.Id)
            {
                TempData["Error"] = _localizer["APIDocIdMismatch"].ToString();
                return RedirectToAction(nameof(Index));
            }

            if (ModelState.IsValid)
            {
                var apiDoc = await _unitOfWork.GetRepository<APIDoc>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (apiDoc == null)
                {
                    TempData["Error"] = _localizer["APIDocNotFound"].ToString();
                    return RedirectToAction(nameof(Index));
                }

                apiDoc.Title = apiDocViewModel.Title;
                apiDoc.Description = apiDocViewModel.Description;
                apiDoc.DescriptionEn = apiDocViewModel.DescriptionEn;
                apiDoc.Endpoint = apiDocViewModel.Endpoint;
                apiDoc.Method = apiDocViewModel.Method;
                apiDoc.RequestExample = apiDocViewModel.RequestExample;
                apiDoc.ResponseExample = apiDocViewModel.ResponseExample;
                apiDoc.Parameters = apiDocViewModel.Parameters;
                apiDoc.UserId = userId ?? string.Empty;

                try
                {
                    await _unitOfWork.GetRepository<APIDoc>().UpdateAsync(apiDoc);
                    TempData["Success"] = _localizer["APIDocUpdatedSuccess"].ToString();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["APIDocUpdateError", ex.Message].ToString();
                }
            }

            ViewData["Title"] = _localizer["EditAPIDocTitle"].ToString();
            return View(apiDocViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            var apiDoc = await _unitOfWork.GetRepository<APIDoc>().GetByIdAsync(id);
            if (apiDoc == null)
            {
                TempData["Error"] = _localizer["APIDocNotFound"].ToString();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Title"] = _localizer["DeleteAPIDocTitle"].ToString();
            return View(apiDoc);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var apiDoc = await _unitOfWork.GetRepository<APIDoc>().GetByIdAsync(id);
            if (apiDoc != null)
            {
                try
                {
                    await _unitOfWork.GetRepository<APIDoc>().RemoveAsync(apiDoc);
                    TempData["Success"] = _localizer["APIDocDeletedSuccess"].ToString();
                }
                catch (Exception ex)
                {
                    TempData["Error"] = _localizer["APIDocDeleteError", ex.Message].ToString();
                }
            }
            else
            {
                TempData["Error"] = _localizer["APIDocNotFound"].ToString();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}