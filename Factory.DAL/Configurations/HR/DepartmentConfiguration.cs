using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments", "HR");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(d => d.NameEn)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(d => d.Code)
                   .HasMaxLength(10);

            builder.Property(d => d.Description)
                   .HasMaxLength(500);

            builder.HasMany(d => d.Employees)
                   .WithOne(e => e.Department)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(d => d.Code)
                   .IsUnique();

            builder.Property(d => d.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}