namespace Factory.PL.ViewModels.Permissions
{
    public class PagePermissionViewModel
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public bool IsSelected { get; set; }
        public List<PermissionTypeViewModel> Permissions { get; set; } = new List<PermissionTypeViewModel>();
    }
}
