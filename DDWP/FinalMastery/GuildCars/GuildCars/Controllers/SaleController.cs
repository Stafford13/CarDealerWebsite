using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Controllers
{
    public class SaleController : Controller
    {
        // GET: Sale
        [Route("sales/index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sales/purchase")]
        public ActionResult purchaseVehicle()
        {
            return View();
        }
    }
}