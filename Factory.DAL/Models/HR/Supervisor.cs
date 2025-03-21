using System.ComponentModel.DataAnnotations;

namespace Factory.DAL.Models.HR
{
    public class Supervisor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string UserId { get; set; } 
    }
}