using Factory.DAL.Models.Permission;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.Permissions
{ 
public class RolePermissionV2ViewModel
{
    [Required(ErrorMessage = "Please select a module")]
    public int ModuleId { get; set; }

    [Required(ErrorMessage = "Please select a submodule")]
    public int SubModuleId { get; set; }

    [Required(ErrorMessage = "Please select at least one page")]
    public List<int> PageIds { get; set; } = new List<int>(); 

    [Required(ErrorMessage = "Please select a role")]
    public string RoleId { get; set; }

    [Required(ErrorMessage = "Please select at least one permission type")]
    public List<int> PermissionIds { get; set; } = new List<int>(); 

    [ValidateNever]
    public ICollection<Module> Modules { get; set; }

    [ValidateNever]
    public ICollection<SubModule> SubModules { get; set; }

    [ValidateNever]
    public ICollection<IdentityRole> Roles { get; set; }

    [ValidateNever]
    public ICollection<Page> Pages { get; set; }

    [ValidateNever]
    public ICollection<PermissionTyepe> PermissionTypes { get; set; }
}
}