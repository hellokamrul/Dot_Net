﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Registration()
        {
            System.Diagnostics.Debug.WriteLine("Hello from GET!");
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Registration r)
        {
  
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("REGISTRATION SUCCESSFUL!");
            } else
            {
                System.Diagnostics.Debug.WriteLine("SHOB KHALI ACHE!");
            }

            return View(r);
        }
    }
}