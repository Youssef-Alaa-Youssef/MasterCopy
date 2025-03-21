using Factory.DAL.Enums.HR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class PerformanceViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }

        [Required]
        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }

        [Required]
        [Display(Name = "Review Period Start")]
        public DateTime ReviewPeriodStart { get; set; }

        [Required]
        [Display(Name = "Review Period End")]
        public DateTime ReviewPeriodEnd { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Productivity Score")]
        public decimal ProductivityScore { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Quality Score")]
        public decimal QualityScore { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Teamwork Score")]
        public decimal TeamworkScore { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Communication Score")]
        public decimal CommunicationScore { get; set; }

        [Required]
        [Range(0, 100)]
        [Display(Name = "Initiative Score")]
        public decimal InitiativeScore { get; set; }

        [Display(Name = "Overall Score")]
        public decimal OverallScore { get; set; }

        [Display(Name = "Manager Feedback")]
        public string ManagerFeedback { get; set; }

        [Display(Name = "Employee Feedback")]
        public string EmployeeFeedback { get; set; }

        [Display(Name = "Goals for Next Period")]
        public string GoalsForNextPeriod { get; set; }

        [Display(Name = "Development Plan")]
        public string DevelopmentPlan { get; set; }

        [Display(Name = "Review Status")]
        public ReviewStatus ReviewStatus { get; set; }
    }
}