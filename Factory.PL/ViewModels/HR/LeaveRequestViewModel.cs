using Factory.DAL.Enums.HR;
using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class LeaveRequestViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Employee field is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "The Start Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "The End Date field is required.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int TotalDays { get; set; }

        [Required(ErrorMessage = "The Type field is required.")]
        public LeaveType Type { get; set; }

        public string Reason { get; set; }

        public LeaveStatus Status { get; set; } = LeaveStatus.Pending;

        public string ApprovedById { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ApprovedDate { get; set; }

        public string RejectionReason { get; set; }
    }
}