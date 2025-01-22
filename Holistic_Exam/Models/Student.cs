using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Holistic_Exam.Models
{
    public class Student
    {
        [Key] public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string ?Name { get; set; }
        [Required]
        [EmailAddress]
        public string ?Email { get; set; }
        [ForeignKey(nameof(Classs.Id))] 
        public int ClassId { get; set; }
        public Classs ?Class { get; set; }
        public Grad ?grad { get; set; }

        public List<Subject> ?Subjects { get; set; }



    }
}
