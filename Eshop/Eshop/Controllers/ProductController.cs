using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Eshop.Controllers.DB;
using Newtonsoft.Json;

namespace Eshop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            ProductEntities p = new ProductEntities();

            return View(p.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Product a)
        {
            ProductEntities s = new ProductEntities();
            s.Products.Add(a);
            s.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int id)
        {
            ProductEntities d = new ProductEntities();
            var a = d.Products.Where(i => i.Id == id).SingleOrDefault();
            /*var ext = (from b in d.Products
                       where b.Id == 
                       select b).SingleOrDefault();*/
            d.Products.Remove(a);
            
            d.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult AddToCart(int id)
        {

            var JSON = "";
            List<Product> products = new List<Product>();
            Product product = new Product();

            var db = new ProductEntities();
            var p = db.Products.Where(i => i.Id == id).SingleOrDefault();

            if (Session["Cart"] == null)
            {
                product.Id = p.Id;
                product.Name = p.Name;
                product.Price = p.Price;
                product.Qty = p.Qty;
                products.Add(product);
                JSON = new JavaScriptSerializer().Serialize(products);
                Session["Cart"] = new JavaScriptSerializer().Serialize(products);

                products.Clear();
            }
            else
            {
                //string json = "{\"Id\":0,\"Name\":\"M10\",\"Price\":\"1000\",\"Qty\":\"20\"}";
                //products.Add(new JavaScriptSerializer().Deserialize<Product>(json));

                string json = Session["Cart"].ToString();
                products = JsonConvert.DeserializeObject<List<Product>>(json);

                product.Id = p.Id;
                product.Name = p.Name;
                product.Price = p.Price;
                product.Qty = p.Qty;
                products.Add(product);

                JSON = new JavaScriptSerializer().Serialize(products);
                Session["Cart"] = JSON;
                products.Clear();
            }
            return RedirectToAction("Products_");
        }

        public ActionResult Checkout()
        {
            if (Session["Cart"] != null)
            {
                string json = Session["Cart"].ToString();
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
                ViewBag.Cart = products;

            }


            return View();
        }

        public ActionResult AddOrder()
        {
            var db = new ProductEntities();

            string json = Session["Cart"].ToString();
            var order = new Oder();
            order.Orders = json;

            db.Oders.Add(order);

            db.SaveChanges();

            Session["Cart"] = null;
            TempData["MSG"] = "YOUR ORDER HAS BEEN CONFIRMED!";
            return RedirectToAction("Products_");
        }

        public ActionResult ClearCart()
        {
            Session["Cart"] = null;
            return RedirectToAction("Products_");
        }

    }
}