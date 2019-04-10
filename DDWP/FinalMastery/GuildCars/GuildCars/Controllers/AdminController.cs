using GuildCars.Data.MockRepo;
using GuildCars.Models;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        [Route("Admin/vehicles")]
        public ActionResult Vehicles()
        {
            return View();
        }

        [Route("Admin/addvehicle")]
        public ActionResult addVehicle()
        {
            //model reference
            return View();
        }

        [Route("Admin/editvehicle")]
        public ActionResult editVehicle()
        {
            return View();
        }

        [Route("Admin/users")]
        public ActionResult Users()
        {
            return View();
        }

        [Route("Admin/editspecial")]
        public ActionResult editSpecial()
        {
            SpecialMockRepo specialRepo = new SpecialMockRepo();
            SpecialsViewModel vm = new SpecialsViewModel();
            vm.Specials = specialRepo.GetAllSpecials();
            return View(vm);
            
        }

        [HttpPost]
        [Route("Admin/editspecial")]
        public ActionResult editSpecial(SpecialsViewModel vm)
        {
            SpecialMockRepo specialRepo = new SpecialMockRepo();
            specialRepo.Create(vm.Special);
            return RedirectToAction("editSpecial");

        }

        [Route("Admin/makes")]
        public ActionResult Makes()
        {
            //IEnumerable<Models.Make> list = new IEnumerable<Models.Makes>
            return View();
        }

        [Route("Admin/models")]
        public ActionResult Models()
        {
            //IEnumerable<Models.Models> list2 = new IEnumerable<Models.Models>
            return View();
        }
    }
}