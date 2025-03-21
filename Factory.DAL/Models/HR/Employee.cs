using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.DAL.Models.HR
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string FirstNameEn { get; set; }

        [StringLength(100)]
        public string LastNameEn { get; set; }

        [Required]
        [StringLength(20)]
        public string EmployeeCode { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? TerminationDate { get; set; }

        public string Address { get; set; }

        public string ImagePath { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        public decimal BaseSalary { get; set; }

        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    }
}