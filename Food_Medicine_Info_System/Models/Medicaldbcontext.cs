using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Food_Medical_Info_System.Models;
namespace Food_Medical_Info_System.Models
{
    public class Medicaldbcontext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Dietician> Dieticians { get; set; }

    }
}