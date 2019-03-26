using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace GuildCars.Data
{
    public class Settings
    {
        private static string _connectionString;

        public static string GetConnectionString()
        {
            if (string.IsNullOrEmpty(_connectionString))
                _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            return _connectionString;
        }
    }
}
