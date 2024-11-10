
using System.ComponentModel.DataAnnotations;

namespace BlazorInfoSysApp.Models
{
    public class Person
    {
        
       public long PersonId { get; set; }

        [Required(ErrorMessage = "Firstname is required.")]
        public string? Firstname { get; set; }
        public string Middlename { get; set; } = String.Empty;

        [Required(ErrorMessage = "Firstname is required.")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Birthdate is required.")]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
        public DateTime? Birthday { get; set; } = null;

        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Civil Status is required.")]
        public string CivilStatus { get; set; } 

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Barangay is required.")]
        public string? Barangay { get; set; }

        [Required(ErrorMessage = "Region is required.")]
        public string? Region { get; set; }

        public string? Municipality { get; set; }

        [Required(ErrorMessage = "Province is required.")]
        public string? Province { get; set; }

        [Required(ErrorMessage = "ZIP Code is required.")]
        public string? ZIP { get; set; }

        [Required(ErrorMessage = "WorkTitle is required. Write N/A if no applicable.")]
        public string? WorkTitle { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = null;

    }
}