using System;
using System.Web.Mvc;

namespace DDWTPractical.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management or /Management/Index
        public ActionResult Index()
        {
            ViewBag.Title = "Manage Products";
            return View();
        }

        // GET: Management/Details
        public ActionResult Details()
        {
            ViewBag.Title = "View Product";
            return View();
        }

        // GET: Management/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create Product";
            return View();
        }

        // GET: Management/Edit 
        public ActionResult Edit()
        {
            ViewBag.Title = "Edit Product";
            return View();
        }

        // GET: Management/Delete 
        public ActionResult Delete()
        {
            ViewBag.Title = "Delete Product";
            return View();
        }
    }
}