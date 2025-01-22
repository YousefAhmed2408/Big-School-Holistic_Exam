using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class Studentandgrade
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; } 
        public GradandClass? Grade { get; set; }

    }
}
