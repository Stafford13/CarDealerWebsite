using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuildCars.Models
{
    public class ModelViewModel
    {
        public IEnumerable<Model> Models { get; set; }
        public Model Model { get; set; }
    }
}