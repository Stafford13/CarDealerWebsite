using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Controllers
{
    //[Authorize(Roles = "sales,admin")]
    public class SaleController : Controller
    {
        // GET: Sale
        [Route("sale/index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("sale/purchase")]
        public ActionResult purchaseVehicle()
        {
            return View();
        }
    }
}