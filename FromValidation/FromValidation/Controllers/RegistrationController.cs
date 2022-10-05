using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FromValidation.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult SignUp()
        {
            return View();
        }
    }
}