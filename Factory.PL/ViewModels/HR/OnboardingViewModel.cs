using Factory.DAL.Enums.HR;

namespace Factory.PL.ViewModels.HR
{
    public class OnboardingViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedCompletionDate { get; set; }
        public DateTime? ActualCompletionDate { get; set; }
        public OnboardingStatus Status { get; set; }
        public int SupervisorId { get; set; }
        public bool OrientationCompleted { get; set; }
        public bool WorkspaceSetupCompleted { get; set; }
        public bool EquipmentProvidedCompleted { get; set; }
        public bool SystemAccessCompleted { get; set; }
        public bool TrainingCompleted { get; set; }
        public bool IntroductionToTeamCompleted { get; set; }
        public bool PoliciesReviewedCompleted { get; set; }
        public bool FirstAssignmentCompleted { get; set; }
        public bool FeedbackSessionCompleted { get; set; }
        public string Notes { get; set; }
    }
}