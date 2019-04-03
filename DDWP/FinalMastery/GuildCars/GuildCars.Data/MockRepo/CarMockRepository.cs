using GuildCars.Data.Interfaces;
using GuildCars.Data.ViewModels;
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
        public void AddFeatured(int carId)
        {
            throw new NotImplementedException();
        }

        public void ChangeToSold(int id)
        {
            throw new NotImplementedException();
        }

        public Car Create(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModel> GetAllCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            throw new NotImplementedException();
        }

        public FeaturedCarsViewModel GetAllFeatures()
        {
            throw new NotImplementedException();
        }

        public CarViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CarInventoryViewModel GetCarInventoryReport()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModel> GetNewCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarViewModel> GetUsedCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100)
        {
            throw new NotImplementedException();
        }

        public void RemoveFeatured(int carId)
        {
            throw new NotImplementedException();
        }

        public Car Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
