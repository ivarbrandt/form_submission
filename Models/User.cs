using System;
using System.ComponentModel.DataAnnotations;

namespace form_submission.Models
{
    public class Model { }
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(0, 150)]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}