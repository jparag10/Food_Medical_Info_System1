using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Food_Medical_Info_System.Models;
namespace Food_Medical_Info_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult User_Register()
        {
                return View();   
        }
        [HttpPost]
        public ActionResult User_Register(User user)
        {
            if (ModelState.IsValid)
            {
                using (var context = new Medicaldbcontext())
                {
                   // context.GuestResponses.Add(user);
                    //context.SaveChanges();
                }
                return View("Search", user);
            }
            else
            {
                return View();
            }
        }

        public ActionResult DieticianReg()
        {

            return View();
        }
    }
}