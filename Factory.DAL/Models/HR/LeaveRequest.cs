using Factory.DAL.Enums.HR;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Factory.DAL.Models.HR
{
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int TotalDays { get; set; }

        [Required]
        public LeaveType Type { get; set; }

        public string Reason { get; set; }

        public LeaveStatus Status { get; set; } = LeaveStatus.Pending;

        public string ApprovedById { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string RejectionReason { get; set; }

        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
