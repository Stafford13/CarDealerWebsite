using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuildCars.Models
{
    public class PurchaseCarViewModel
    {
        public Car Car { get; set; }
        public Sale Sale { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}