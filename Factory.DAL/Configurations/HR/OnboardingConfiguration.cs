using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class OnboardingConfiguration : IEntityTypeConfiguration<Onboarding>
    {
        public void Configure(EntityTypeBuilder<Onboarding> builder)
        {
            builder.ToTable("Onboardings", "HR");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.EmployeeId).IsRequired();
            builder.Property(o => o.StartDate).IsRequired();
            builder.Property(o => o.ExpectedCompletionDate).IsRequired();
            builder.Property(o => o.ActualCompletionDate).IsRequired(false);
            builder.Property(o => o.Status).IsRequired();
            builder.Property(o => o.SupervisorId).IsRequired();
            builder.Property(o => o.OrientationCompleted).IsRequired();
            builder.Property(o => o.WorkspaceSetupCompleted).IsRequired();
            builder.Property(o => o.EquipmentProvidedCompleted).IsRequired();
            builder.Property(o => o.SystemAccessCompleted).IsRequired();
            builder.Property(o => o.TrainingCompleted).IsRequired();
            builder.Property(o => o.IntroductionToTeamCompleted).IsRequired();
            builder.Property(o => o.PoliciesReviewedCompleted).IsRequired();
            builder.Property(o => o.FirstAssignmentCompleted).IsRequired();
            builder.Property(o => o.FeedbackSessionCompleted).IsRequired();
            builder.Property(o => o.Notes).HasMaxLength(1000);
            builder.Property(o => o.UserId).HasMaxLength(450);
            builder.Property(o => o.CreatedAt).IsRequired();

            builder.HasOne<Employee>()
                   .WithMany()
                   .HasForeignKey(o => o.EmployeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Supervisor>()
                   .WithMany()
                   .HasForeignKey(o => o.SupervisorId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}