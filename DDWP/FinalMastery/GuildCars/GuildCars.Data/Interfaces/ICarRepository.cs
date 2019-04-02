using System.Collections.Generic;
using GuildCars.Data.ViewModels;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Interfaces
{
    public interface ICarRepository
    {
        Car Create(Car car);
        Car Update(Car car);
        void Delete(int id);
        CarViewModel GetById(int id);
        IEnumerable<CarViewModel> GetNewCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100);
        IEnumerable<CarViewModel> GetUsedCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100);
        IEnumerable<CarViewModel> GetAllCarsSorted(string searchText = null, decimal minPrice = 0, decimal maxPrice = 900000000, int minYear = 0, int maxYear = 2100);
        CarInventoryViewModel GetCarInventoryReport();
        void AddFeatured(int carId);
        void RemoveFeatured(int carId);
        FeaturedCarsViewModel GetAllFeatures();
        void ChangeToSold(int id);
    }
}
