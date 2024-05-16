using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class Student
    {
        [RegularExpression(@"^.{12,12}$")]       
        [Required]
        public long StudentId { get; set; }

        
        [Required]
        [RegularExpression(@"^\d{12}$", ErrorMessage ="valami")]
        [MaxLength(12)]
        public string? StudentId2 { get; set; }

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
    