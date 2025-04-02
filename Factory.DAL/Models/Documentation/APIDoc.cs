using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Factory.DAL.Models.Documentation
{
    /// <summary>
    /// Represents an API endpoint documentation
    /// </summary>
    [Table("APIDocs", Schema = "docs")]
    public class APIDoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public bool IsPublic { get; set; } = false;

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(2000)]
        public string DescriptionEn { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Endpoint { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public string Method { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string RequestExample { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string ResponseExample { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Parameters { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [MaxLength(450)]
        public string UserId { get; set; } = string.Empty;

        public virtual ICollection<APIParameter> ParametersList { get; set; } = new List<APIParameter>();
    }

    /// <summary>
    /// Represents a parameter for an API endpoint
    /// </summary>
    [Table("APIParameters", Schema = "docs")]
    public class APIParameter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string NameEn { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Type { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string TypeEn { get; set; } = string.Empty;

        [Required]
        public bool Required { get; set; } = false;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string DescriptionEn { get; set; } = string.Empty;

        [ForeignKey("APIDoc")]
        public int APIDocId { get; set; }

        public virtual APIDoc APIDoc { get; set; } = null!;
    }

    /// <summary>
    /// Represents an API response status code documentation
    /// </summary>
    [Table("APIResponses", Schema = "docs")]
    public class APIResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int StatusCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string DescriptionEn { get; set; } = string.Empty;

        [Column(TypeName = "nvarchar(max)")]
        public string? Example { get; set; }

        [ForeignKey("APIDoc")]
        public int APIDocId { get; set; }

        public virtual APIDoc APIDoc { get; set; } = null!;
    }
}