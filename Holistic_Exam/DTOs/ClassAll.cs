using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class ClassAll
    {

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public TeacherDTO ?teacher { get; set; }
        public List<StudentDTO> ?students { get; set; }

    }
}
