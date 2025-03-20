namespace Factory.PL.ViewModels.Permissions
{
    public class ModulePermissionViewModel
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public bool IsSelected { get; set; }
        public List<SubModulePermissionViewModel> SubModules { get; set; } = new List<SubModulePermissionViewModel>();
    }
}
