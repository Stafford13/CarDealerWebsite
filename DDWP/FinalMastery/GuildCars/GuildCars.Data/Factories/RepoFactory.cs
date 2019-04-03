using GuildCars.Data.ADO;
using GuildCars.Data.Interfaces;
using GuildCars.Data.MockRepo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.Factories
{
    public class RepoFactory
    {
        public static ICarRepository Create()
        {

            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            ICarRepository carRepo;
            switch (mode)
            {

                case "SampleData":
                    carRepo = new CarMockRepository();
                    return carRepo;

                default:
                    throw new Exception("Mode value in app config is not valid");
            }
        }
    }
}
