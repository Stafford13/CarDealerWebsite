using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.MockRepo
{
    public class CarMockRepository : ICarRepository
    {
        private static List<Car> _cars;
        static CarMockRepository()
        {
            _cars = new List<Car>

        {
            new Car
            {
                CarId = 1,
                Body = "SUV",
                Year = 2013,
                Mileage = 0,
                ExColor = "Black",
                IntColor = "Tan",
                Transmission = true,
                Type = "New",
                MSRP = 5,
                Price = 10000,
                ImageFileName = "Car1.PNG",
                MakeId = 1,
                ModelId = 1,
                isFeatured = true,
                isSold = false
            },
            new Car
            {
                CarId = 2,
                Body = "Sedan",
                Year = 2015,
                Mileage = 0,
                ExColor = "Black",
                IntColor = "Tan",
                Transmission = false,
                Type = "New",
                MSRP = 5,
                Price = 10000,
                ImageFileName = "Car2.PNG",
                MakeId = 1,
                ModelId = 2,
                isFeatured = true,
                isSold = false
            },
            new Car
            {
                CarId = 3,
                Body = "Sedan",
                Year = 2015,
                Mileage = 0,
                ExColor = "Red",
                IntColor = "Rainbow",
                Transmission = false,
                Type = "New",
                MSRP = 5,
                Price = 10000,
                ImageFileName = "Car2.PNG",
                MakeId = 3,
                ModelId = 1,
                isFeatured = false,
                isSold = false
            },
            new Car
            {
                CarId = 4,
                Body = "SUV",
                Year = 2010,
                Mileage = 10000,
                ExColor = "Black",
                IntColor = "Tan",
                Transmission = true,
                Type = "Used",
                MSRP = 5,
                Price = 10,
                ImageFileName = "Car1.PNG",
                MakeId = 2,
                ModelId = 1,
                isFeatured = false,
                isSold = true
            }
        };
            }

        public Car Create(Car car)
        {
            int id = _cars.Max(c => c.CarId) + 1;
            _cars.Add(car);

            return car;
        }

        public void Delete(int id)
        {
            Car car = _cars.FirstOrDefault(c => c.CarId == id);
            _cars.Remove(car);
        }

        public IEnumerable<Car> GetAllFeatures()
        {
            return _cars.Where(c => c.isFeatured == true);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.FirstOrDefault(c => c.CarId == id);
        }

        public IEnumerable<Car> GetAllNotSold()
        {
            return _cars.Where(c => c.isSold == false);
        }

        public IEnumerable<Car> GetNewCars(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            //instantiate make and model repos
            //3 embedded if statements
            //return _cars.Where()
        }

        public IEnumerable<Car> GetUsedCars(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetNotSoldCars(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car car)
        {
            Car update = _cars.FirstOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(update);
            _cars.Add(car);

            return car;
        }

        public void ChangeToSold(int id)
        {
            throw new NotImplementedException();
        }
    }
}
