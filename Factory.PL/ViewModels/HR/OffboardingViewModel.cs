using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class OffboardingViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Last Working Date")]
        public DateTime LastWorkingDate { get; set; }

        [Display(Name = "Exit Interview Date")]
        public DateTime? ExitInterviewDate { get; set; }

        [Required]
        [Display(Name = "Termination Reason")]
        public string TerminationReason { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Supervisor ID")]
        public int? SupervisorId { get; set; }

        [Display(Name = "Notice Given Date")]
        public DateTime? NoticeGivenDate { get; set; }

        [Display(Name = "Return of Company Property Completed")]
        public bool ReturnOfCompanyPropertyCompleted { get; set; }

        [Display(Name = "Access Revocation Completed")]
        public bool AccessRevocationCompleted { get; set; }

        [Display(Name = "Knowledge Transfer Completed")]
        public bool KnowledgeTransferCompleted { get; set; }

        [Display(Name = "Exit Interview Completed")]
        public bool ExitInterviewCompleted { get; set; }

        [Display(Name = "Final Payment Completed")]
        public bool FinalPaymentCompleted { get; set; }

        [Display(Name = "Benefits Termination Completed")]
        public bool BenefitsTerminationCompleted { get; set; }

        [Display(Name = "Reference Arrangement Completed")]
        public bool ReferenceArrangementCompleted { get; set; }

        [Display(Name = "Farewell Event Completed")]
        public bool FarewellEventCompleted { get; set; }

        [Display(Name = "Feedback Provided")]
        public bool FeedbackProvided { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }
}