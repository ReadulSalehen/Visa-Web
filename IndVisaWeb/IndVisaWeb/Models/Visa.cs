using System.ComponentModel.DataAnnotations;

namespace IndVisaWeb.Models
{
    public class Visa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Country name should be more than 2 characters")]
        public string Country { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Indian Mission Office name should be more than 2 characters")]
        public string IndianMissionOffice { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Nationality name should be more than 2 characters")]
        public string Nationality { get; set; } = string.Empty;
        [Required]
        public DateTime? DateofBirth { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(6, ErrorMessage = "Email name should be more than 6 characters")]
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime? ExpectedDateOfArivel { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Visa Type name should be more than 2 characters")]
        public string VisaType { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Visa Type name should be more than 2 characters")]
        public string Purpose { get; set; } = string.Empty;
    }
}
