using System;
using System.Collections.Generic;
using System.Text;

namespace GuildCars.Models.Tables
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
