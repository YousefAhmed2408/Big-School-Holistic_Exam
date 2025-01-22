using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class ClassDTO
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
    }
}
