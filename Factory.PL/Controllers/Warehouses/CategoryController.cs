using Factory.DAL.Models.Warehouses;
using Microsoft.AspNetCore.Mvc;
using Factory.DAL.ViewModels.Warehouses;
using Microsoft.AspNetCore.Authorization;
using Factory.BLL.InterFaces;

namespace Factory.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(IUnitOfWork unitOfWork, ILogger<CategoryController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IActionResult> Index(int warehouseId)
        {
            var categories = await _unitOfWork.GetRepository<Category>().FindAsync(cat=>cat.MainWarehouseId == warehouseId);
            ViewBag.warehouseId = warehouseId;
            return View(categories);
        }

        public IActionResult AddCategory(int warehouseId)
        {
            var viewModel = new CategoryViewModel
            {
                MainWarehouseId = warehouseId
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategory(CategoryViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );

                return Json(new { success = false, errors = errors });
            }

            var category = ToDomainModel(viewModel);

            await _unitOfWork.GetRepository<Category>().AddAsync(category);
            await _unitOfWork.SaveChangesAsync();

            return Json(new { success = true, message = "Category added successfully!" });
        }

        [HttpGet("EditCategory/{id}")]
        public async Task<IActionResult> EditCategory(int id)
        {
            var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var viewModel = ToViewModel(category);
            return View(viewModel);
        }

        [HttpPost("EditCategory/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, CategoryViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            try
            {
                var category = ToDomainModel(viewModel);
                await _unitOfWork.GetRepository<Category>().UpdateAsync(category);
                await _unitOfWork.SaveChangesAsync();

                return RedirectToAction(nameof(Index), new { warehouseId = viewModel.MainWarehouseId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating category.");
                ModelState.AddModelError("", "An error occurred while updating the category.");
                return View(viewModel);
            }
        }

        [HttpPost("DeleteCategory/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(id);
                if (category == null)
                {
                    return NotFound();
                }

                await _unitOfWork.GetRepository<Category>().RemoveAsync(category);
                await _unitOfWork.SaveChangesAsync();
                return Json(new { success = true, message = "Category deleted successfully!" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting category.");
                return Json(new { success = false, message = "An error occurred while deleting the category." });
            }
        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories(int id)
        {
            try
            {
                var categories = _unitOfWork.GetRepository<Category>().Query()
                    .Where(c => c.MainWarehouseId == id)
                    .Select(c => new { c.Id, c.NameEn })
                    .ToList();

                return Json(categories);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching categories for warehouse ID {WarehouseId}.", id);
                return Json(new { success = false, message = "An error occurred while fetching categories." });
            }
        }

        public static CategoryViewModel ToViewModel(Category category)
        {
            return new CategoryViewModel
            {
                Id = category.Id,
                NameEn = category.NameEn,
                NameAr = category.NameAr,
                DescriptionEn = category.DescriptionEn,
                DescriptionAr = category.DescriptionAr,
                MainWarehouseId = category.MainWarehouseId,
                HasDimensions = category.HasDimensions,
                DefaultWidth = category.DefaultWidth,
                DefaultHeight = category.DefaultHeight,
                DefaultThickness = category.DefaultThickness
            };
        }

        public static Category ToDomainModel(CategoryViewModel viewModel)
        {
            return new Category
            {
                Id = viewModel.Id,
                NameEn = viewModel.NameEn,
                NameAr = viewModel.NameAr,
                DescriptionEn = viewModel.DescriptionEn,
                DescriptionAr = viewModel.DescriptionAr,
                MainWarehouseId = viewModel.MainWarehouseId,
                HasDimensions = viewModel.HasDimensions,
                DefaultWidth = viewModel.DefaultWidth,
                DefaultHeight = viewModel.DefaultHeight,
                DefaultThickness = viewModel.DefaultThickness
            };
        }
    }
}