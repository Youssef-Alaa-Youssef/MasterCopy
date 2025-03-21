using Factory.DAL.Models.HR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Factory.DAL.Configurations.HR
{
    public class OffboardingConfiguration : IEntityTypeConfiguration<Offboarding>
    {
        public void Configure(EntityTypeBuilder<Offboarding> builder)
        {
            builder.ToTable("Offboardings", "HR");

            builder.HasKey(o => o.Id);

            builder.Property(o => o.EmployeeId).IsRequired();
            builder.Property(o => o.LastWorkingDate).IsRequired();
            builder.Property(o => o.ExitInterviewDate).IsRequired(false);
            builder.Property(o => o.TerminationReason).HasMaxLength(500);
            builder.Property(o => o.Status).HasMaxLength(50);
            builder.Property(o => o.SupervisorId).IsRequired(false);
            builder.Property(o => o.NoticeGivenDate).IsRequired(false);
            builder.Property(o => o.ReturnOfCompanyPropertyCompleted).IsRequired();
            builder.Property(o => o.AccessRevocationCompleted).IsRequired();
            builder.Property(o => o.KnowledgeTransferCompleted).IsRequired();
            builder.Property(o => o.ExitInterviewCompleted).IsRequired();
            builder.Property(o => o.FinalPaymentCompleted).IsRequired();
            builder.Property(o => o.BenefitsTerminationCompleted).IsRequired();
            builder.Property(o => o.ReferenceArrangementCompleted).IsRequired();
            builder.Property(o => o.FarewellEventCompleted).IsRequired();
            builder.Property(o => o.FeedbackProvided).IsRequired();
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