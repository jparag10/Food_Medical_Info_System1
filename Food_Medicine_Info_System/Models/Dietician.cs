﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Food_Medical_Info_System.Models
{
    public class Dietician
    {
        [Key]
        public int did { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in valid format. Ex. of correct email: paragjain@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^(?=.{8,})$", ErrorMessage = "Password should be min 6 chars includin alphanumeric")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your Contact no")]
        public int Contact { get; set; }
        [Required(ErrorMessage = "Please enter your Location")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter your Experience")]
        public int Experience { get; set; }
            
    }
}