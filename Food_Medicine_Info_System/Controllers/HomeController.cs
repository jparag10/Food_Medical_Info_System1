using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Food_Medical_Info_System.Models;
namespace Food_Medical_Info_System.Controllers
{
    public class HomeController : Controller
    {
        Medicaldbcontext mc = new Medicaldbcontext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration()
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
                   context.Users.Add(user);
                   context.SaveChanges();
                }
                return View("Search", user);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult DieticianReg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DieticianReg(Dietician diet, HttpPostedFileBase postedFile)
        {
            
           
            if (ModelState.IsValid)
            {
                if (postedFile!=null)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);

                    ////Set the Image File Path.
                    string filePath = "~/Uploads/" + fileName;

                    ////Save the Image File in Folder.
                    postedFile.SaveAs(Server.MapPath(filePath));


                    diet.filepath = filePath;
                }
               

                ////Insert the Image File details in Table.
                //// FilesEntities entities = new FilesEntities();
                //db.images.Add(new Dietician
                //{
                //    Name = fileName,
                //    FilePath = filePath
                //});
                using (var context = new Medicaldbcontext())
                {

                     
                    try
                    {
                        context.Dieticians.Add(diet);
                        context.SaveChanges();
                    }
                    catch(Exception)
                    {
                        ViewBag.Email = "Duplicate Email";
                        return View(diet);
                    }
                       
                    
                }
                return View("Search", diet);
            }
            else
            {
                return View();
            }
        }
    }
}