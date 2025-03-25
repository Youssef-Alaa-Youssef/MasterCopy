using Factory.DAL.Enums.Stores;

namespace Factory.PL.ViewModels.Reports
{
    public class WarehouseUtilizationViewModel
    {
        public string WarehouseName { get; set; }
        public int UtilizationPercentage { get; set; }
        public int CurrentStock { get; set; }
        public int Capacity { get; set; }
        public WarehouseStatus Status { get; set; }
    }
}
