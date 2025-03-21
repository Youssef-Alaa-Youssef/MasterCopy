using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.DAL.Models.HR
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string TitleEn { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public string Description { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}