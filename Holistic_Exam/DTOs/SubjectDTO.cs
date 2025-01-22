using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class SubjectDTO
    {
        [Required]
        [MaxLength(10)]
        public string? Duration { get; set; }

    }
}
