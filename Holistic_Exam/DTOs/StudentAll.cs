using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class StudentAll
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
          public ClassandGrad? ClassandGrad {  get; set; }

    }
}
