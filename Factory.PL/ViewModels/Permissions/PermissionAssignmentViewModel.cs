namespace Factory.PL.ViewModels.Permissions
{
    public class PermissionAssignmentViewModel
    {
        public string RoleId { get; set; }
        public List<PermissionAssignment> Permissions { get; set; } = new List<PermissionAssignment>();
    }
}
