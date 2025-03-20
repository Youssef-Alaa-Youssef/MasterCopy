namespace Factory.PL.ViewModels.Permissions
{
    public class SubModulePermissionViewModel
    {
        public int SubModuleId { get; set; }
        public string SubModuleName { get; set; }
        public bool IsSelected { get; set; }
        public List<PagePermissionViewModel> Pages { get; set; } = new List<PagePermissionViewModel>();
    }
}
