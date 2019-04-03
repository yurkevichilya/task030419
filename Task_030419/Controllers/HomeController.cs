using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_030419.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult News()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult AboutUZ()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult LogIn()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Registration()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
