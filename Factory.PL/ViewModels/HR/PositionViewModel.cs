using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class PositionViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(100, ErrorMessage = "The Title must be at most 100 characters long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The English Title field is required.")]
        [StringLength(100, ErrorMessage = "The English Title must be at most 100 characters long.")]
        public string TitleEn { get; set; }

        [StringLength(10, ErrorMessage = "The Code must be at most 10 characters long.")]
        public string Code { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "The Department field is required.")]
        public int DepartmentId { get; set; }
    }
}