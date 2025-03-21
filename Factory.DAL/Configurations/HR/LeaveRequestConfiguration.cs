using Factory.DAL.Enums.HR;
using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.ToTable("LeaveRequests", "HR");

            builder.HasKey(lr => lr.Id);

            builder.Property(lr => lr.StartDate)
                   .IsRequired();

            builder.Property(lr => lr.EndDate)
                   .IsRequired();

            builder.Property(lr => lr.TotalDays)
                   .IsRequired();

            builder.Property(lr => lr.Type)
                   .IsRequired();

            builder.Property(lr => lr.Reason)
                   .HasMaxLength(500);

            builder.Property(lr => lr.Status)
                   .HasDefaultValue(LeaveStatus.Pending);

            builder.Property(lr => lr.RejectionReason)
                   .HasMaxLength(500);

            builder.HasOne(lr => lr.Employee)
                   .WithMany(e => e.LeaveRequests)
                   .HasForeignKey(lr => lr.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(lr => lr.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}