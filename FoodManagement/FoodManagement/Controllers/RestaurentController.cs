using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using FoodManagement.DB;
using static System.Net.Mime.MediaTypeNames;

namespace FoodManagement.Controllers
{
    public class RestaurentController : Controller
    {
        public ActionResult Index()
        {
            int id = Convert.ToInt32(Session["user"]);
            var db = new NgoEntities();
            var profile = (from b in db.Restaurents
                        where b.Rid == id
                           select b).SingleOrDefault();
            return View(profile);
            
        }

        // GET: Restaurent
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Restaurent r )
        {
            var db = new NgoEntities();
            db.Restaurents.Add( r );
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult CreatePost()
        {
            return View();
        }


            [HttpPost]
        public ActionResult CreatePost(Post p)
        {
           var db = new NgoEntities();
            var customers = db.Set<Post>();
            customers.Add(new Post { Rid = Convert.ToInt32(Session["user"]) , Pid = 1, Amount = p.Amount, Comment = p.Comment, Date = p.Date });



            db.SaveChanges();
            return View();
        }
    }
}