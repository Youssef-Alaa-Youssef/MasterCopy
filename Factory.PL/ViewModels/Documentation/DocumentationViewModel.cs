using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.Documentation
{
    public class DocumentationViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "TitleRequired")]
        [StringLength(100, ErrorMessage = "TitleLength")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "TitleRequired")]
        [StringLength(100, ErrorMessage = "TitleLength")]
        public string TitleEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "DescriptionRequired")]
        [StringLength(200, ErrorMessage = "DescriptionLength")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "DescriptionRequired")]
        [StringLength(200, ErrorMessage = "DescriptionLength")]
        public string DescriptionEn { get; set; } = string.Empty;

        [Required(ErrorMessage = "ContentRequired")]
        public string Content { get; set; } = string.Empty;

        public string? ContentEn { get; set; } = string.Empty;

        [Display(Name = "VideoUrlDisplay")]
        [Url(ErrorMessage = "VideoUrlInvalid")]
        public string VideoUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
    }
}