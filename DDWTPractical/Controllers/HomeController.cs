using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTPractical.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/ or Home/Index
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        // GET: Home/ or Home/Details
        public ActionResult Details()
        {
            ViewBag.Title = "Product";
            return View();
        }

        // GET: Home/About
        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "About Amazon Orders...";

            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "Contact Amazon Orders...";

            return View();
        }
    }
}