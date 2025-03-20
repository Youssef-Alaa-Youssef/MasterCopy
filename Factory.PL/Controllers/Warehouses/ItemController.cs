using Factory.BLL.InterFaces;
using Factory.DAL.Models;
using Factory.DAL.Models.Warehouses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Factory.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(IUnitOfWork unitOfWork, ILogger<ItemsController> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IActionResult> Index(int categoryId)
        {
            var items = await _unitOfWork.GetRepository<Item>().Query()
                .Where(i => i.CategoryId == categoryId)
                .ToListAsync();

            ViewBag.CategoryId = categoryId;
            return View(items);
        }

        [HttpGet]
        public async Task<IActionResult> AddItem(int categoryId)
        {
            try
            {
                if (categoryId <= 0)
                {
                    TempData["Error"] = "Invalid category ID.";
                    return RedirectToAction(nameof(Index)); 
                }
                var category = await _unitOfWork.GetRepository<Category>().GetByIdAsync(categoryId);

                if (category == null)
                {
                    TempData["Error"] = $"Category with ID {categoryId} not found.";
                    return RedirectToAction(nameof(Index)); 
                }

                await PopulateViewBagsForItem(categoryId, category);
                TempData["Success"] = "Category and countries loaded successfully.";
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding item.");
                ModelState.AddModelError(string.Empty, "An error occurred while adding the item.");
                await PopulateViewBagsForItem(categoryId);
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem([FromForm] Item item)
        {
            if (!ModelState.IsValid)
            {
                await PopulateViewBagsForItem(item.CategoryId);
                return View(item);
            }
            if (!await _unitOfWork.GetRepository<Country>().AnyAsync<Country>(c => c.Id == item.ManufacturingCountryId))
            {
                ModelState.AddModelError("ManufacturingCountryId", "Invalid country selected.");
                await PopulateViewBagsForItem(item.CategoryId);
                return View(item);
            }

            try
            {
                await _unitOfWork.GetRepository<Item>().AddAsync(item);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { categoryId = item.CategoryId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding item.");
                ModelState.AddModelError(string.Empty, "An error occurred while adding the item.");
                await PopulateViewBagsForItem(item.CategoryId);
                return View(item);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditItem(int id)
        {
            var item = await _unitOfWork.GetRepository<Item>().GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            await PopulateViewBagsForItem(item.CategoryId, item.Category);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditItem(int id, [FromForm] Item item)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                await PopulateViewBagsForItem(item.CategoryId);
                return View(item);
            }

            try
            {
                await _unitOfWork.GetRepository<Item>().UpdateAsync(item);
                await _unitOfWork.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { categoryId = item.CategoryId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating item.");
                ModelState.AddModelError(string.Empty, "An error occurred while updating the item.");
                await PopulateViewBagsForItem(item.CategoryId);
                return View(item);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var item = await _unitOfWork.GetRepository<Item>().GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            await PopulateViewBagsForItem(item.CategoryId);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteItem(int id)
        {
            try
            {
                var item = await _unitOfWork.GetRepository<Item>().GetByIdAsync(id);
                if (item == null)
                {
                    return NotFound();
                }

                await _unitOfWork.GetRepository<Item>().RemoveAsync(item);
                await _unitOfWork.SaveChangesAsync();
                return Json(new { success = true, message = "Item deleted successfully!" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting item.");
                return Json(new { success = false, message = "An error occurred while deleting the item." });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetItems(int id)
        {
            try
            {
                var items = await _unitOfWork.GetRepository<Item>().Query()
                    .Where(i => i.CategoryId == id)
                    .Select(i => new
                    {
                        i.Id,
                        i.CodeNumber,
                        i.NameEn,
                        i.NameAr,
                        i.CurrentStock,
                        IsLowStock = i.IsLowStock()
                    })
                    .ToListAsync();

                var result = new
                {
                    Items = items,
                    Insights = new
                    {
                        TotalItems = items.Count,
                        LowStockItems = items.Count(i => i.IsLowStock)
                    }
                };

                ViewBag.Show = id;
                return Json(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching items.");
                return Json(new { success = false, message = "An error occurred while fetching items." });
            }
        }

        [HttpGet]
        public async Task<IActionResult> Countries()
        {
            var countries = await _unitOfWork.GetRepository<Country>().GetAllAsync();
            return View(countries);
        }

        [HttpGet("items/bycountry/{countryId}")]
        public async Task<IActionResult> GetItemsByCountry(int countryId)
        {
            var items = await _unitOfWork.GetRepository<Item>()
                .Query()
                .Where(i => i.ManufacturingCountryId == countryId)
                .Select(i => new
                {
                    i.NameEn,
                    i.CodeNumber,
                    i.DescriptionEn,
                    i.CurrentStock
                })
                .ToListAsync();

            return Json(items);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStocks(int id, [FromBody] UpdateStockRequest request)
        {
            try
            {
                var item = await _unitOfWork.GetRepository<Item>().GetFirstOrDefaultAsync(i => i.Id == id);

                if (item == null)
                {
                    return Json(new { success = false, message = "Item not found." });  // Return JSON response for failure
                }

                if (request.Quantity > item.CurrentStock)
                {
                    return Json(new { success = false, message = $"Requested quantity exceeds available stock. Available stock: {item.CurrentStock}." });
                }

                if (request.Quantity <= 0)
                {
                    return Json(new { success = false, message = "Quantity must be greater than zero." });
                }

                item.UpdateStock(request.Quantity);

                await _unitOfWork.SaveChangesAsync();
                return Json(new { success = true, message = "Stock updated successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"An error occurred: {ex.Message}" });
            }
        }

        public class UpdateStockRequest
        {
            public int Quantity { get; set; }
        }
        private async Task PopulateViewBagsForItem(int categoryId, Category category = null)
        {
            category ??= await _unitOfWork.GetRepository<Category>().GetByIdAsync(categoryId);
            var countries = await _unitOfWork.GetRepository<Country>().GetAllAsync();
            var mainWarehouses = await _unitOfWork.GetRepository<MainWarehouse>().GetAllAsync();
            var subWarehouses = await _unitOfWork.GetRepository<SubWarehouse>().GetAllAsync();

            ViewBag.Category = category;
            ViewBag.Countries = new SelectList(countries, "Id", "NameEn");
            ViewBag.MainWarehouses = new SelectList(mainWarehouses, "Id", "NameEn");
            ViewBag.SubWarehouses = new SelectList(subWarehouses, "Id", "NameEn");
            ViewBag.HasDimensions = category?.HasDimensions ?? false;
        }
    }
}