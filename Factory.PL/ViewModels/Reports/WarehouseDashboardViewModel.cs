
namespace Factory.PL.ViewModels.Reports
{
    public class WarehouseDashboardViewModel
    {
        public int TotalMainWarehouses { get; set; }
        public int TotalSubWarehouses { get; set; }
        public int TotalWarehouseCapacity { get; set; }
        public int CurrentTotalStock { get; set; }
        public int UtilizationPercentage { get; set; }
        public List<LowStockItemViewModel> LowStockItems { get; set; } = new List<LowStockItemViewModel>();
        public List<WarehouseStatusDistributionViewModel> WarehouseStatusDistribution { get; set; } = new List<WarehouseStatusDistributionViewModel>();
        public List<RecentActivityViewModel> RecentActivities { get; set; } = new List<RecentActivityViewModel>();
        public List<WarehouseUtilizationViewModel> TopUtilizedWarehouses { get; set; } = new List<WarehouseUtilizationViewModel>();
        public DateTime LastUpdated { get; set; }
    }
}
