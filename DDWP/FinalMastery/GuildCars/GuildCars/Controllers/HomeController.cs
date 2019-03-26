using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let us know how we did!";

            return View();
        }

        public ActionResult New()
        {
            ViewBag.Message = "Check out our new vehicles.";

            return View();
        }

        public ActionResult Used()
        {
            ViewBag.Message = "Check out our legacy models,";

            return View();
        }

        public ActionResult Specials()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}