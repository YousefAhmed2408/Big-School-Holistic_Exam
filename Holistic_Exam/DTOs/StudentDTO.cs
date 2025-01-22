﻿using System.ComponentModel.DataAnnotations;

namespace Holistic_Exam.DTOs
{
    public class StudentDTO
    {
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
    }
}
