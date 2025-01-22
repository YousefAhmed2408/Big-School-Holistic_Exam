using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class ClassandStudents
    {
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        public List<StudentandSubjects> ?Students { get; set; }

    }
}
