using Factory.DAL.Enums.HR;
using System.ComponentModel.DataAnnotations;

namespace Factory.DAL.Models.HR
{
    public class Performance
    {
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        [Required]
        public DateTime ReviewPeriodStart { get; set; }

        [Required]
        public DateTime ReviewPeriodEnd { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal ProductivityScore { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal QualityScore { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal TeamworkScore { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal CommunicationScore { get; set; }

        [Required]
        [Range(0, 100)]
        public decimal InitiativeScore { get; set; }

        [Required]
        public decimal OverallScore { get; set; }

        public string ManagerFeedback { get; set; }

        public string EmployeeFeedback { get; set; }

        public string GoalsForNextPeriod { get; set; }

        public string DevelopmentPlan { get; set; }

        public ReviewStatus ReviewStatus { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedAt { get; set; }
    }

}