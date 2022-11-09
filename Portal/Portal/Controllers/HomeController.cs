using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using Portal.Controllers.DB;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
       public ActionResult Index()
        {
            return View();
        }
        [HttpPost]  
        
        public ActionResult Index(Students s)
        {
            return RedirectToAction("StudntProfile", "Registration");
        }
    }
}