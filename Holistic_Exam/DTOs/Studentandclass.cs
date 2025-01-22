using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class Studentandclass
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
         public ClassDTO ?classDTO { get; set; }

    }
}
