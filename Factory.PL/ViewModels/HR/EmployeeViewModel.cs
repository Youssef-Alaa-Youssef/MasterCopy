using System.ComponentModel.DataAnnotations;

namespace Factory.PL.ViewModels.HR
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "الاسم الأول مطلوب")]
        [Display(Name = "الاسم الأول")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "الاسم الأخير مطلوب")]
        [Display(Name = "الاسم الأخير")]
        public string LastName { get; set; }

        [Display(Name = "الاسم الأول بالإنجليزية")]
        public string FirstNameEn { get; set; }

        [Display(Name = "الاسم الأخير بالإنجليزية")]
        public string LastNameEn { get; set; }

        [Required(ErrorMessage = "كود الموظف مطلوب")]
        [Display(Name = "كود الموظف")]
        public string EmployeeCode { get; set; }

        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "بريد إلكتروني غير صالح")]
        [Display(Name = "البريد الإلكتروني")]
        public string Email { get; set; }

        [Display(Name = "رقم الهاتف")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "تاريخ الميلاد مطلوب")]
        [DataType(DataType.Date)]
        [Display(Name = "تاريخ الميلاد")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "تاريخ التوظيف مطلوب")]
        [DataType(DataType.Date)]
        [Display(Name = "تاريخ التوظيف")]
        public DateTime HireDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "تاريخ إنهاء الخدمة")]
        public DateTime? TerminationDate { get; set; }

        [Display(Name = "العنوان")]
        public string Address { get; set; }

        [Display(Name = "الصورة")]
        public IFormFile ImageFile { get; set; }

        public string ImagePath { get; set; }

        [Required(ErrorMessage = "القسم مطلوب")]
        [Display(Name = "القسم")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "الوظيفة مطلوبة")]
        [Display(Name = "الوظيفة")]
        public int PositionId { get; set; }

        [Required(ErrorMessage = "الراتب الأساسي مطلوب")]
        [Display(Name = "الراتب الأساسي")]
        public decimal BaseSalary { get; set; }

        public DateTime CreatedAt { get; set; }

        [Display(Name = "نشط")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "اسم القسم")]
        public string DepartmentName { get; set; }

        [Display(Name = "اسم الوظيفة")]
        public string PositionTitle { get; set; }

        [Display(Name = "الاسم الكامل")]
        public string FullName => $"{FirstName} {LastName}";
    }
}