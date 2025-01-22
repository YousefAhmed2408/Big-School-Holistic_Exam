using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class GradDTO
    {
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(10)]
        public string? Grade { get; set; }
    }
}
