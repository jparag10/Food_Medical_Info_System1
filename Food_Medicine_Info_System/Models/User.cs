using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Food_Medical_Info_System.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int ContactNo{ get; set; }
        public double Height { get; set; }
        public double Weight{ get; set; }
        public int Age{ get; set; }


    }
}