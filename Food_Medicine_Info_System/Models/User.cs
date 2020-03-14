using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Food_Medical_Info_System.Models
{
    public class User
    {
        [Key]
        public int userid { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^(?=.{8,})$", ErrorMessage = "Password should be min 6 chars includin alphanumeric")]
        public string Password { get; set; }

        //[RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in valid format. Ex. of correct email: paragjain@gmail.com")]

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please enter your Contact no")]
        public int ContactNo{ get; set; }

        [Required(ErrorMessage = "Please enter your Height")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Please enter your Weight")]
        public double Weight{ get; set; }

        [Required(ErrorMessage = "Please enter your Age")]
        public int Age{ get; set; }


    }
}