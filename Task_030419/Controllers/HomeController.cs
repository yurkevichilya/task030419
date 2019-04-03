using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using Task_030419.Models;

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
        [HttpPost]
        public ActionResult LogIn(LogInModel logInModel)
        {
            if (!ModelState.IsValid)
            {
                return View("LogIn");
            }
            else
            {
                XmlSerializer formatter = new XmlSerializer(typeof(LogInModel));

                using (FileStream fs = new FileStream("LogIn.xml", FileMode.Append))
                {
                    formatter.Serialize(fs, logInModel);
                }
                return View("Index");
            }
        }
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(RegisterModel registerModel)
        {

            if (!ModelState.IsValid)
            {
                return View("Registration");
            }
            else {
                XmlSerializer formatter = new XmlSerializer(typeof(RegisterModel));

                using (FileStream fs = new FileStream("RegisterModel.xml", FileMode.Append))
                {
                    formatter.Serialize(fs, registerModel);
                }
                return View("Index");
            }
        }
    }
}
