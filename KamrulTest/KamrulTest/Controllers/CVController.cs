using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KamrulTest.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.RESULT = "GPA" + (4.2 + 1.0);
            return View();
        }
    }
}