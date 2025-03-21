using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class SupervisorConfiguration : IEntityTypeConfiguration<Supervisor>
    {
        public void Configure(EntityTypeBuilder<Supervisor> builder)
        {
            builder.ToTable("Supervisors", "HR");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.FullName).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Email).HasMaxLength(100);
            builder.Property(s => s.PhoneNumber).HasMaxLength(20);
            builder.Property(s => s.CreatedAt).IsRequired();
            builder.Property(s => s.UserId).HasMaxLength(450);
        }
    }
}