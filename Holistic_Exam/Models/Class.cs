using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Holistic_Exam.Models
{
    public class Classs
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string ?Name { get; set; }
        [ForeignKey(nameof(Teacher.Id))]
        public int TeacherID {  get; set; }
        public Teacher ?teacher { get; set;}
        public List<Student> ?Students { get; set; }

        
    }
}
