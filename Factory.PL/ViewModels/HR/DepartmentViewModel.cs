using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم القسم مطلوب")]
        [Display(Name = "اسم القسم")]
        public string Name { get; set; }

        [Required(ErrorMessage = "اسم القسم بالإنجليزية مطلوب")]
        [Display(Name = "اسم القسم بالإنجليزية")]
        public string NameEn { get; set; }

        [Display(Name = "الكود")]
        public string Code { get; set; }

        [Display(Name = "الوصف")]
        public string Description { get; set; }

        //[Display(Name = "الصورة")]
        //public IFormFile ImageFile { get; set; }

        //public string ImagePath { get; set; }

        public DateTime CreatedAt { get; set; }

        [Display(Name = "عدد الموظفين")]
        public int EmployeeCount { get; set; }
    }
}