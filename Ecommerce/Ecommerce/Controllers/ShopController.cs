using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Models.DB;

namespace Ecommerce.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Shop()
        {
            //receive book from db
            var db = new ProductEntities();
            var products = db.Products.ToList();
            return View(products);
            
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return View();

        }
        [HttpPost]  
        public ActionResult Create(Product s)
        {
            var db = new ProductEntities();
            db.Products.Add(s);
            db.SaveChanges();
            return View();
        }

       


    }
}