﻿using System.ComponentModel.DataAnnotations;

namespace OnlineLearningSystem.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }  // Student, Faculty, Admin
    }
}
