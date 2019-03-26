﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GuildCars.Models.Tables
{
    public class Car
    {
        public int CarId { get; set; }
        public string Body { get; set; }
        public int Year { get; set; }
        public int Milage { get; set; }
        public string ExColor { get; set; }
        public string IntColor { get; set; }
        public bool Transmission { get; set; }
        public string Type { get; set; }
        public int MSRP { get; set; }
        public int Price { get; set; }
        public Make MakeName { get; set; }
        public Model ModelName { get; set; }
    }
}
