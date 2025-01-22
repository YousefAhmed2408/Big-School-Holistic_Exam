using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class ClassandGrad
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
          public List<GradDTO> ?Grads { get; set; }

    }
}
