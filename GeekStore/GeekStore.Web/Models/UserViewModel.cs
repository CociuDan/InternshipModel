﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GeekStore.UI.Models
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public virtual string FullName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsAdmin { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public virtual string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public virtual string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public virtual string ConfirmPassword { get; set; }
    }
}