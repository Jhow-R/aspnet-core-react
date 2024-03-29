﻿using System.ComponentModel.DataAnnotations;

namespace AlunosApi.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar senha")]
        [Compare(nameof(Password), ErrorMessage = "Senhas não conferem")]
        public string ConfirmPassword { get; set; }
    }
}
