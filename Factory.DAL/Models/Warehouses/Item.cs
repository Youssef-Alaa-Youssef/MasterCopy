using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.DAL.Models.Warehouses
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Code Number")]
        public string CodeNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [Display(Name = "Name (English)")]
        public string NameEn { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        [Display(Name = "Name (Arabic)")]
        public string NameAr { get; set; } = string.Empty;

        [MaxLength(250)]
        [Display(Name = "Description (English)")]
        public string DescriptionEn { get; set; } = string.Empty;

        [MaxLength(250)]
        [Display(Name = "Description (Arabic)")]
        public string DescriptionAr { get; set; } = string.Empty;

        [Display(Name = "Minimum Stock")]
        public int MinimumStock { get; set; } = 10;

        [Display(Name = "Current Stock")]
        public int CurrentStock { get; set; } = 0;

        [Display(Name = "Unit of Measure")]
        public string UnitOfMeasure { get; set; } = "Piece";

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Display(Name = "Updated Date")]
        public DateTime? UpdatedDate { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Thickness must be a valid number with up to two decimal places.")]
        [Display(Name = "Thickness")]
        public double Thickness { get; set; } = 4.0;

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Width must be a valid number with up to two decimal places.")]
        [Display(Name = "Width")]
        public double Width { get; set; } = 0;

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Height must be a valid number with up to two decimal places.")]
        [Display(Name = "Height")]
        public double Height { get; set; } = 0;

        [Display(Name = "Color")]
        public string Color { get; set; } = "Clear";

        [Display(Name = "Is Toughened")]
        public bool IsToughened { get; set; } = false;

        [Display(Name = "Is Laminated")]
        public bool IsLaminated { get; set; } = false;

        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Display(Name = "Rank")]
        public int Rank { get; set; }

        [Display(Name = "Manufacturing Country ID")]
        public int ManufacturingCountryId { get; set; }

        [ForeignKey("ManufacturingCountryId")]
        [Display(Name = "Manufacturing Country")]
        public virtual Country? ManufacturingCountry { get; set; } 

        [ForeignKey("CategoryId")]
        [Display(Name = "Category")]
        public virtual Category? Category { get; set; }

        public bool IsLowStock()
        {
            return CurrentStock <= MinimumStock;
        }

        public void UpdateStock(int quantity)
        {
            CurrentStock -= quantity; 
            UpdatedDate = DateTime.UtcNow;
        }

    }
}