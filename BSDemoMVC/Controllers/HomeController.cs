using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us tag line.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Quality()
        {
            return View();
        }
        public ActionResult Client()
        {
            return View();
        }
        public ActionResult Infrastructure()
        {
            return View();
        }

        public ActionResult Research()
        {
            return View();
        }
    }
}