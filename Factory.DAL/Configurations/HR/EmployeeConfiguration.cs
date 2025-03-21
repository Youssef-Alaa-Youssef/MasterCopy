using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees", "HR");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.LastName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.FirstNameEn)
                   .HasMaxLength(100);

            builder.Property(e => e.LastNameEn)
                   .HasMaxLength(100);

            builder.Property(e => e.EmployeeCode)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(e => e.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Phone)
                   .HasMaxLength(15);

            builder.Property(e => e.Address)
                   .HasMaxLength(500);

            builder.Property(e => e.ImagePath)
                   .HasMaxLength(500);

            builder.Property(e => e.BaseSalary)
                   .HasColumnType("decimal(18, 2)");

            builder.Property(e => e.IsActive)
                   .HasDefaultValue(true);

            builder.HasOne(e => e.Department)
                   .WithMany(d => d.Employees)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Position)
                   .WithMany(p => p.Employees)
                   .HasForeignKey(e => e.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(e => e.EmployeeCode)
                   .IsUnique();

            builder.HasIndex(e => e.Email)
                   .IsUnique();

            builder.Property(e => e.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}