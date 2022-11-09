using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration.Controllers.DB;

namespace Registration.Controllers
{
    public class PreRegistrationController : Controller
    {
        // GET: PreRegistration
        [HttpGet]
        public ActionResult Index()
        {
            PortalEntities db = new PortalEntities();

            return View(db.Courses.ToList());
        }
        [HttpPost]
        public ActionResult Index(int[] Courses)
        {
            PortalEntities db = new PortalEntities();
            foreach (var course in Courses)
            {
                db.CourseStudents.Add(new CourseStudents()
                {
                    CourseId = course,
                    StudentId = 1,
                    
                    
                    
                });

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Student()
        {
            PortalEntities db = new PortalEntities();
            return View(db.Students.ToList());
        }
    }
}