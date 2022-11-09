using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbCrud.Models.Context;

namespace DbCrud.Controllers
{
    public class StudentController : Controller
    {
        db_testEntities db = new db_testEntities();
        // GET: Student

        public ActionResult Student()
        {
            //receive book from db

            var info = db.tbl_Student.ToList();
            return View(info);
            //return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_Student student)
        {
            db.tbl_Student.Add(student);
            db.SaveChanges();
            return RedirectToAction("Student");
            //return View();
        }

    }


    }