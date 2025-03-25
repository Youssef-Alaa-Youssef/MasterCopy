using Factory.BLL.InterFaces;
using Factory.DAL.Enums;
using Factory.DAL.Models.OrderList;
using Factory.DAL.Models.Warehouses;
using Factory.PL.ViewModels.OrderList;
using Factory.PL.ViewModels.Reports;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Factory.PL.Controllers
{
    public class ReportController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [CheckPermission(Permissions.Read)]
        public async Task<IActionResult> OrderDashboard()
        {
            var orders = await _unitOfWork.GetRepository<Order>().GetAllAsync();
            var orderItems = await _unitOfWork.GetRepository<OrderItem>().GetAllAsync();

            var totalOrders = orders.Count();
            var deliveredOrders = orders.Count(o => o.Items.All(i => i.IsDelivered));
            var pendingOrders = orders.Count(o => o.Items.Any(i => !i.IsDelivered));
            var cancelledOrders = orders.Count(o => o.Status == "Cancelled");

            var orderDetails = orders.Select(o => new OrderDetailViewModel
            {
                OrderId = o.Id,
                CustomerName = o.CustomerName,
                OrderDate = o.Date,
                Status = o.Status,
                DeliveryStatus = o.Items.All(i => i.IsDelivered) ? "Delivered" : "Not Delivered",
                TotalItems = o.Items.Count,
                TotalSQM = o.TotalSQM,
                TotalLM = o.TotalLM,
                JobNum = o.JobNo,
            }).ToList();

            //var monthlyDeliveries = new List<int> { 12, 19, 3, 5, 2, 3, 7, 8, 9, 10, 11, 12 }; // Replace with actual data
            var totalSQMData = orders.Select(o => o.TotalSQM).ToList(); 
            var totalLMData = orders.Select(o => o.TotalLM).ToList(); 
            var totalItemsData = orders.Select(o => o.Items.Count).ToList(); 

            var orderStatusDistribution = new Dictionary<string, int>
        {
            { "Delivered", deliveredOrders },
            { "Pending", pendingOrders },
            { "Cancelled", cancelledOrders }
        };

            //var topCustomers = orders
            //    .GroupBy(o => o.CustomerName)
            //    .OrderByDescending(g => g.Count())
            //    .Take(5)
            //    .ToDictionary(g => g.Key, g => g.Count());

            var viewModel = new OrderReportViewModel
            {
                TotalOrders = totalOrders,
                //DeliveredOrders = deliveredOrders,
                //PendingOrders = pendingOrders,
                //CancelledOrders = cancelledOrders,
                Orders = orderDetails,
                //MonthlyDeliveries = monthlyDeliveries,
                TotalSQMData = totalSQMData,
                TotalLMData = totalLMData,
                TotalItemsData = totalItemsData,
                OrderStatusDistribution = orderStatusDistribution,
                //TopCustomers = topCustomers,
            };

            return View(viewModel);
        }


        public async Task<IActionResult> WarehouseDashboard()
        {
            try
            {
                // Get repositories
                var mainWarehouseRepo = _unitOfWork.GetRepository<MainWarehouse>();
                var subWarehouseRepo = _unitOfWork.GetRepository<SubWarehouse>();
                var itemRepo = _unitOfWork.GetRepository<Item>();
                var categoryRepo = _unitOfWork.GetRepository<Category>();

                // Get base data
                var mainWarehouses = await mainWarehouseRepo.GetAllAsync();
                var subWarehouses = await subWarehouseRepo.GetAllAsync();
                var items = await itemRepo.GetAllAsync();
                var categories = await categoryRepo.GetAllAsync();

                foreach (var warehouse in mainWarehouses)
                {
                    warehouse.SubWarehouses = subWarehouses.Where(s => s.MainWarehouseId == warehouse.Id).ToList();
                    warehouse.Categories = categories.Where(c => c.MainWarehouseId == warehouse.Id).ToList();

                    foreach (var category in warehouse.Categories)
                    {
                        category.Items = items.Where(i => i.CategoryId == category.Id).ToList();
                    }
                }

                // Calculate metrics
                var totalCapacity = mainWarehouses.Sum(w => w.Capacity) + subWarehouses.Sum(w => w.Capacity);
                var currentStock = mainWarehouses.Sum(w => w.CurrentStock) + subWarehouses.Sum(w => w.CurrentStock);
                var utilizationPercentage = totalCapacity > 0 ? (int)((currentStock * 100) / totalCapacity) : 0;

                var lowStockItems = items.Where(i => i.IsLowStock())
                                       .Select(i => new LowStockItemViewModel
                                       {
                                           ItemId = i.Id,
                                           ItemName = i.NameEn,
                                           CurrentStock = i.CurrentStock,
                                           MinimumStock = i.MinimumStock,
                                           CategoryName = categories.FirstOrDefault(c => c.Id == i.CategoryId)?.NameEn ?? "N/A"
                                       })
                                       .OrderBy(i => i.CurrentStock)
                                       .Take(20)
                                       .ToList();

                var statusDistribution = mainWarehouses
                    .Concat(subWarehouses.Cast<MainWarehouse>())
                    .GroupBy(w => w.Status)
                    .Select(g => new WarehouseStatusDistributionViewModel
                    {
                        Status = g.Key,
                        Count = g.Count()
                    })
                    .ToList();

                var recentActivities = items
                    .OrderByDescending(i => i.UpdatedDate ?? i.CreatedDate)
                    .Take(10)
                    .Select(i => new RecentActivityViewModel
                    {
                        ItemName = i.NameEn,
                        ActivityDate = i.UpdatedDate ?? i.CreatedDate,
                        ActivityType = i.UpdatedDate.HasValue ? "Stock Updated" : "Item Created",
                        ItemId = i.Id
                    })
                    .ToList();

                var topUtilizedWarehouses = mainWarehouses
                    .Select(w => new WarehouseUtilizationViewModel
                    {
                        WarehouseName = w.NameEn,
                        UtilizationPercentage = w.Capacity > 0 ? (int)((w.CurrentStock * 100) / w.Capacity) : 0,
                        CurrentStock = w.CurrentStock,
                        Capacity = w.Capacity,
                        Status = w.Status
                    })
                    .OrderByDescending(w => w.UtilizationPercentage)
                    .Take(5)
                    .ToList();

                var viewModel = new WarehouseDashboardViewModel
                {
                    TotalMainWarehouses = mainWarehouses.Count(),
                    TotalSubWarehouses = subWarehouses.Count(),
                    TotalWarehouseCapacity = totalCapacity,
                    CurrentTotalStock = currentStock,
                    UtilizationPercentage = utilizationPercentage,
                    LowStockItems = lowStockItems,
                    WarehouseStatusDistribution = statusDistribution,
                    RecentActivities = recentActivities,
                    TopUtilizedWarehouses = topUtilizedWarehouses,
                    LastUpdated = DateTime.Now
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while loading the dashboard");
            }
        }
    }
}
