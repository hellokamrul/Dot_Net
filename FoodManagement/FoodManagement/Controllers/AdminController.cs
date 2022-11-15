using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using FoodManagement.DB;
using FoodManagement.Models;
using Microsoft.Ajax.Utilities;
using Task = FoodManagement.DB.Task;

namespace FoodManagement.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Employee()
        {
            var db = new NgoEntities();
            var employees = db.Collectors.ToList();
            return View(employees);
        }

        [HttpGet]
        public ActionResult Post()
        {

            var db = new NgoEntities();
            var posts = db.Posts.ToList();
            var p = db.Collectors.ToList();
            var d = db.Tasks.ToList();
            ViewBag.task = d;
            ViewBag.emp = p;
           

            return View(posts);
        }


        [HttpGet]
        public ActionResult Assign(int id)
        {




            var db = new NgoEntities();
            var employees = db.Collectors.ToList();
            ViewBag.employees = employees;
            ViewBag.id= id;
            return View();
        }


      
        [HttpPost]
        public ActionResult Assign(Task t)
        {
            var db = new NgoEntities();

            
            db.Tasks.Add(t);

            db.SaveChanges();

            return RedirectToAction("Post");
        }


        [HttpGet]
        public ActionResult Accept(Task t)
        {
            var db = new NgoEntities();

            db.Tasks.Add(t);

            db.SaveChanges();

            return RedirectToAction("Post");
        }

       
    }
}