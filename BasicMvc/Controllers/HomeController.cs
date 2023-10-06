using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WhoAmi = "Customer";
            ViewBag.TitlePage = "Index Page";
            return View();
        }
        public ActionResult Products()
        {
            var products = new List<String>();
            products.Add("Product 1");
            products.Add("Product 2");
            products.Add("Product 3");
            ViewBag.products = products;

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicApp = Request.PhysicalApplicationPath;
            return View("Contacts");
        }
        public ActionResult Greet()
        {
            return Content("Hello guys");
        }
        public ActionResult TestShared()
        {
            return View("TestShared");
        }
    }
}