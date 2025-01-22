using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.Models
{
    public class Grad
    {
        [Key] public int Id { get; set; }
        [Required]
        public int Year  { get; set; }
        [Required]
        [MaxLength(10)]
        public string ?Grade { get; set; }
        public List<Student>? Students { get; set; }

    }
}
