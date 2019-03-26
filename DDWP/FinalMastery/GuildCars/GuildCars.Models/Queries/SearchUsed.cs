using System;
using System.Collections.Generic;
using System.Text;

namespace GuildCars.Models.Queries
{
    public class SearchUsed
    {
        public string MakeName { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}
