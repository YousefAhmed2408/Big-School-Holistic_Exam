using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class GradandClass
    {
        [Required]
        public int Year { get; set; }
        [Required]
        [MaxLength(10)]
        public string? Grade { get; set; }
        public Class_and_Teacher Teacher { get; set; }

    }
}
