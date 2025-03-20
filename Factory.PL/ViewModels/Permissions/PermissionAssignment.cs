namespace Factory.PL.ViewModels.Permissions
{
    public class PermissionAssignment
    {
        public int ModuleId { get; set; }
        public int? SubModuleId { get; set; }
        public int? PageId { get; set; }
        public int PermissionId { get; set; }
        public bool IsGranted { get; set; }
    }
}
