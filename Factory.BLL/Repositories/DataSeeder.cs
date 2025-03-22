using Factory.BLL.InterFaces;
using Factory.DAL.Enums;
using Factory.DAL.Models.Auth;
using Factory.DAL.Models.Permission;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory.DAL.Configurations
{
    public class DataSeeder
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();

            await CreateRoles(roleManager);
            await CreateDefaultUsersForRoles(userManager);
            await CreatePermissions(unitOfWork);
            await AssignRolePermissions(roleManager, unitOfWork);
        }

        private static async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                string roleName = role.ToString();
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }

        private static async Task CreateDefaultUsersForRoles(UserManager<ApplicationUser> userManager)
        {
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                string roleName = role.ToString();
                string defaultUserEmail = $"{roleName.ToLower()}@MasterCopy.info";
                string defaultPassword = $"{roleName}@123";

                var defaultUser = await userManager.FindByEmailAsync(defaultUserEmail);

                if (defaultUser == null)
                {
                    defaultUser = new ApplicationUser
                    {
                        UserName = defaultUserEmail,
                        Email = defaultUserEmail,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(defaultUser, defaultPassword);

                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(defaultUser, roleName);
                    }
                }
            }
        }

        private static async Task CreatePermissions(IUnitOfWork unitOfWork)
        {
            var permissionRepository = unitOfWork.GetRepository<PermissionTyepe>();
            var existingPermissions = await permissionRepository.GetAllAsync();

            var requiredPermissions = new List<string> { "Delete", "Read", "Create", "Update" };

            var newPermissions = requiredPermissions
                .Where(permissionName => !existingPermissions.Any(p => p.Name == permissionName))
                .Select(permissionName => new PermissionTyepe { Name = permissionName })
                .ToList();

            if (newPermissions.Any())
            {
                await permissionRepository.AddRangeAsync(newPermissions);
                await unitOfWork.SaveChangesAsync();
            }
        }

        private static async Task AssignRolePermissions(RoleManager<IdentityRole> roleManager, IUnitOfWork unitOfWork)
        {
            var moduleRepository = unitOfWork.GetRepository<Module>();
            var allModules = await moduleRepository.GetAllAsync();

            var subModuleRepository = unitOfWork.GetRepository<SubModule>();
            var allSubModules = await subModuleRepository.GetAllAsync();

            var pageRepository = unitOfWork.GetRepository<Page>();
            var allPages = await pageRepository.GetAllAsync();

            var permissionRepository = unitOfWork.GetRepository<PermissionTyepe>();
            var allPermissions = await permissionRepository.GetAllAsync();

            var rolePermissionRepository = unitOfWork.GetRepository<RolePermission>();
            var existingRolePermissions = await rolePermissionRepository.GetAllAsync();

            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                var roleName = role.ToString();
                var identityRole = await roleManager.FindByNameAsync(roleName);

                if (identityRole != null && allModules.Any())
                {
                    var newRolePermissions = new List<RolePermission>();

                    if (roleName == UserRole.SuperAdmin.ToString())
                    {
                        foreach (var module in allModules)
                        {
                            foreach (var subModule in allSubModules.Where(sm => sm.ModuleId == module.Id))
                            {
                                foreach (var page in allPages.Where(p => p.SubmoduleId == subModule.Id))
                                {
                                    foreach (var permission in allPermissions)
                                    {
                                        if (!existingRolePermissions.Any(rp => rp.RoleId == identityRole.Id &&
                                                                              rp.PermissionId == permission.Id &&
                                                                              rp.ModuleId == module.Id &&
                                                                              rp.SubModuleId == subModule.Id &&
                                                                              rp.PageId == page.Id))
                                        {
                                            newRolePermissions.Add(new RolePermission
                                            {
                                                RoleId = identityRole.Id,
                                                PermissionId = permission.Id,
                                                ModuleId = module.Id,
                                                SubModuleId = subModule.Id,
                                                PageId = page.Id
                                            });
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    if (newRolePermissions.Any())
                    {
                        await rolePermissionRepository.AddRangeAsync(newRolePermissions);
                        await unitOfWork.SaveChangesAsync();
                    }
                }
            }
        }
    }
}