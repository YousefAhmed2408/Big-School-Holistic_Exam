using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Holistic_Exam.Models
{
    public class Subject
    {
        [Key] public int Id { get; set; }
        [ForeignKey(nameof(Student.Id))]
        public int StudentId { get; set; }
        public List<Student> ?students { get; set;}
        [Required]
        [MaxLength(10)]
        public string ?Duration { get; set;}



    }
}
