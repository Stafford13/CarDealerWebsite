using GuildCars.Data.ADO;
using NUnit.Framework;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Tests
{
    [TestFixture]
    public class ADO_Tests
    {
        //[Test]
        //public void CanLoadSpecials()
        //{
        //    var repo = new ....
        //      CHECK OUT VIDEO 7
        //}

        [Test]
        public void CanLoadCar()
        {
            var repo = new CarRepositoryADO();
            var car = repo.GetById(1);

            Assert.IsNotNull(car);

            //values (1, 'SUV', '2010', 'Black', 'Tan', '3500', '1', 
            //'Used', '40000', '45000','1', '1', 'Car1'),
            Assert.AreEqual(1, car.CarId);
            Assert.AreEqual("SUV", car.Body);
            Assert.AreEqual("2010", car.Year);
            Assert.AreEqual("Black", car.ExColor);
            Assert.AreEqual("Tan", car.IntColor);
            Assert.AreEqual("3500", car.Mileage);
            Assert.AreEqual("1", car.Transmission);
            Assert.AreEqual("Used", car.Type);
            Assert.AreEqual("40000", car.MSRP);
            Assert.AreEqual("45000", car.Price);
            Assert.AreEqual("Honda", car.MakeName);
            Assert.AreEqual("Accord", car.ModelName);
            Assert.AreEqual("Car1", car.ImageFileName);
        }

        [Test]
        public void NotFoundCarReturnsNull()
        {
            var repo = new CarRepositoryADO();
            var car = repo.GetById(100000);

            Assert.IsNull(car);
        }

        [Test]
        public void CanAddCar()
        {
            Car carToAdd = new Car();
            var repo = new CarRepositoryADO();

            carToAdd.CarId = 1;
            carToAdd.Body = "SUV";
            carToAdd.Year = 2010;
            carToAdd.ExColor = "Black";
            carToAdd.IntColor = "Tan";
            carToAdd.Transmission = true;
            carToAdd.Type = "Used";
            carToAdd.MSRP = 40000;
            carToAdd.Price = 45000;
            //carToAdd.MakeName = "Honda";
            //carToAdd.ModelName = "Accord";
            carToAdd.ImageFileName = "Car1";

            repo.Insert(carToAdd);

            Assert.AreEqual(2, carToAdd.CarId);
        }
    }
}
