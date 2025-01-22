using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Holistic_Exam.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string ?Email{ get; set;}
        
        public string ?Phone {  get; set; }
        public  Classs ?Class { get; set; }

    }
}
