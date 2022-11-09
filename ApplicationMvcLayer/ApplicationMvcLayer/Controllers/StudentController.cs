using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLC;


namespace ApplicationMvcLayer.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var data = StudentService.Get();
            return View(data);
        }
    }
}