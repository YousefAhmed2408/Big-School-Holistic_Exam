using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class Class_and_Teacher
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public TeacherDTO ?Teacher { get; set; }
    }
}
