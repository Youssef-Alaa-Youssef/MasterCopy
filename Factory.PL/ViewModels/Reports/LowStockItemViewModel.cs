namespace Factory.PL.ViewModels.Reports
{
    public class LowStockItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CurrentStock { get; set; }
        public int MinimumStock { get; set; }
        public string CategoryName { get; set; }
    }
}
