using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class StudentandSubjects
    {

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public List<SubjectDTO> ?Subjects { get; set; }

    }
}
