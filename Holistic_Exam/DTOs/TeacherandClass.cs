using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class TeacherandClass
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Phone { get; set; }
       public ClassDTO?Class { get; set; }


    }
}
