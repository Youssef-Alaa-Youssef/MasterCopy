using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.DAL.Models.HR
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string NameEn { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; } = new List<Position>();

        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}