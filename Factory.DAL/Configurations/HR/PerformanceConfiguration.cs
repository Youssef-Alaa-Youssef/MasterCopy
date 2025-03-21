using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class PerformanceConfiguration : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            builder.ToTable("Performances", "HR");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.EmployeeId).IsRequired();
            builder.Property(p => p.ReviewDate).IsRequired();
            builder.Property(p => p.ReviewPeriodStart).IsRequired();
            builder.Property(p => p.ReviewPeriodEnd).IsRequired();
            builder.Property(p => p.ProductivityScore).IsRequired();
            builder.Property(p => p.QualityScore).IsRequired();
            builder.Property(p => p.TeamworkScore).IsRequired();
            builder.Property(p => p.CommunicationScore).IsRequired();
            builder.Property(p => p.InitiativeScore).IsRequired();
            builder.Property(p => p.OverallScore).IsRequired();
            builder.Property(p => p.ManagerFeedback).HasMaxLength(1000);
            builder.Property(p => p.EmployeeFeedback).HasMaxLength(1000);
            builder.Property(p => p.GoalsForNextPeriod).HasMaxLength(1000);
            builder.Property(p => p.DevelopmentPlan).HasMaxLength(1000);
            builder.Property(p => p.ReviewStatus).IsRequired();
            builder.Property(p => p.UserId).HasMaxLength(450);
            builder.Property(p => p.CreatedAt).IsRequired();

            builder.HasOne<Employee>()
                   .WithMany()
                   .HasForeignKey(p => p.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}