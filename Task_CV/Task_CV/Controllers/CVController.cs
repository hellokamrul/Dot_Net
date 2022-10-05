using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_CV.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Reference()
        {
            return View();
        }
    }
}