using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using FoodManagement.DB;

namespace FoodManagement.Controllers
{
    public class CollectorController : Controller
    {
        // GET: Collector
        public ActionResult Index()
        {
            var db = new NgoEntities();
            int id = Convert.ToInt32(Session["user"]);
            var tasks = (from b in db.Tasks
                         where b.Cid == id select b).ToList();
                
            return View(tasks);
        }

        public ActionResult PostView()
        {
            var db = new NgoEntities();
           var posts = db.Posts.ToList();

            return View(posts);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Collector r)
        {
            var db = new NgoEntities(); 
            db.Collectors.Add(r);
            db.SaveChanges();
            return View();
        }
    }
}