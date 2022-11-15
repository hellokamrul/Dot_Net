using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using FoodManagement.DB;
using FoodManagement.Models;
using Type = FoodManagement.Models.Type;

namespace FoodManagement.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Loing()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
             
           
            
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Type user)
        {
           
             
               if (user.Id == 2)
                {
                    
                    return RedirectToAction("Registration", "Collector");

                }
                else if (user.Id == 3)
                {
                    
                    return RedirectToAction("Registration", "Restaurent");

                }
                else
            {
                
            }

            return View("Login");

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(Login user)
        {

            var db = new NgoEntities();
         

            if(user.Type == 1)
            {
                var a = db.Admins.Where(i => i.Email == user.Email && i.Password == user.Password).SingleOrDefault();

                if(a != null)
                {
                    Session["user"] = a.Id;
                    return RedirectToAction("Index", "Admin");
                }
            }
            else if (user.Type == 3)
            {
                var a = db.Restaurents.Where(i => i.Email == user.Email && i.Password == user.Password).SingleOrDefault();

                if (a != null)
                {
                    Session["user"] = a.Rid;
                    return RedirectToAction("Index", "Restaurent");
                }
            }
            else if(user.Type == 2)
            {
                var a = db.Collectors.Where(i => i.Email == user.Email && i.Password == user.Password).SingleOrDefault();

                if (a != null)
                {
                    Session["user"] = a.Id;
                    return RedirectToAction("Index", "Collector");
                }
            }

            return View();
        }
        


    

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}