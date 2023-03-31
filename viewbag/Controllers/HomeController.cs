using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewbag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult index1(int? id, string name, double? price)
        {
            ViewBag.id = id;
            ViewBag.name = name;
            ViewBag.price = price;
            return View();
        }
        public ViewResult display2()
        {
            List<string> food = new List<string>() { " biryani", "lemon rice", "gulabjaamon", "panipuri", "noodles" };
                ViewBag.food = food;
            return View();
        }
    }
}