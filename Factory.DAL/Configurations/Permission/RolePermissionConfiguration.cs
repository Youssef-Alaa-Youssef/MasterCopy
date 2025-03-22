using Factory.DAL.Models.Permission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.Permission
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("RolePermissions");

            // Use a simpler primary key (e.g., just Id)
            builder.HasKey(rp => rp.Id);

            // Role relationship
            builder.HasOne(rp => rp.Role)
                .WithMany()
                .HasForeignKey(rp => rp.RoleId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade

            // Permission relationship
            builder.HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade

            // Module relationship
            builder.HasOne(rp => rp.Module)
                .WithMany(m => m.RolePermissions)
                .HasForeignKey(rp => rp.ModuleId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade

            // SubModule relationship
            builder.HasOne(rp => rp.SubModule)
                .WithMany()
                .HasForeignKey(rp => rp.SubModuleId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade

            // Page relationship
            builder.HasOne(rp => rp.Page)
                .WithMany()
                .HasForeignKey(rp => rp.PageId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade
        }
    }
}