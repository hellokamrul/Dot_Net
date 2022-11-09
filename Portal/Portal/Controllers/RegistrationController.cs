using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portal.Controllers.DB;

namespace Portal.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Students s)
        {
            UniversityEntities db = new UniversityEntities();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult StudntProfile(Students n)
        {
            var db = new UniversityEntities();
            var StudentId = (from b in db.Students
                            where b.StudentId == "19-39635-1" &&
                            b.Password == "123"
                            select b).SingleOrDefault();
            if (StudentId != null)
            {
                
                return View(StudentId);
            }
            return View();
        }
    }
}