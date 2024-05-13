using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Student
    {
        [MinLength(12)]
        [MaxLength(12)]
        [Required]
        public Int64 StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public string GetFullname()
        {
            return $"{FName} {LName}";
        }
            
    }
}
    