using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        [Route("reports/index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("reports/inventory")]
        public ActionResult Inventory()
        {
            return View();
        }

        [Route("reports/sales")]
        public ActionResult salesReport()
        {
            return View();
        }
    }
}