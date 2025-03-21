namespace Factory.DAL.Models.HR
{
    public class Offboarding
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LastWorkingDate { get; set; }
        public DateTime? ExitInterviewDate { get; set; }
        public string TerminationReason { get; set; }
        public string Status { get; set; }
        public int? SupervisorId { get; set; }
        public DateTime? NoticeGivenDate { get; set; }
        public bool ReturnOfCompanyPropertyCompleted { get; set; }
        public bool AccessRevocationCompleted { get; set; }
        public bool KnowledgeTransferCompleted { get; set; }
        public bool ExitInterviewCompleted { get; set; }
        public bool FinalPaymentCompleted { get; set; }
        public bool BenefitsTerminationCompleted { get; set; }
        public bool ReferenceArrangementCompleted { get; set; }
        public bool FarewellEventCompleted { get; set; }
        public bool FeedbackProvided { get; set; }
        public string Notes { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
