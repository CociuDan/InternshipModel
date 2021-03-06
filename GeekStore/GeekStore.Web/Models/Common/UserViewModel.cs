﻿using System.ComponentModel.DataAnnotations;

namespace GeekStore.UI.Models.Common
{
    public class UserViewModel
    {
        public int Id { get; protected set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public bool IsAdmin { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{6,18}", ErrorMessage = "Password is predictible.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }
    }
}