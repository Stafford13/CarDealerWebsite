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
            MakeMockRepo makeRepo = new MakeMockRepo();
            MakeMockRepo vm = new MakeMockRepo();
            vm.Makes = makeRepo.GetAllMakes();
            return View(vm);
        }

        [HttpPost]
        [Route("Admin/makes")]
        public ActionResult Makes(MakeViewModel vm)
        {
            MakeMockRepo makeRepo = new MakeMockRepo();
            makeRepo.Create(vm.Make);
            return RedirectToAction("Makes");
        }

        [Route("Admin/models")]
        public ActionResult Models()
        {
            ModelMockRepo modelRepo = new ModelMockRepo();
            ModelViewModel vm = new ModelViewModel();
            vm.Models = modelRepo.GetAllModels();
            return View(vm);
        }

        [HttpPost]
        [Route("Admin/models")]
        public ActionResult Models(ModelViewModel vm)
        {
            ModelMockRepo modelRepo = new ModelMockRepo();
            modelRepo.Create(vm.Model);
            return RedirectToAction("Models");
        }
    }
}