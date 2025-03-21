using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Positions", "HR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.TitleEn)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Code)
                   .HasMaxLength(10);

            builder.Property(p => p.Description)
                   .HasMaxLength(500);

            builder.HasOne(p => p.Department)
                   .WithMany(d => d.Positions)
                   .HasForeignKey(p => p.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(p => p.Employees)
                   .WithOne(e => e.Position)
                   .HasForeignKey(e => e.PositionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(p => p.Code)
                   .IsUnique();

            builder.Property(p => p.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}