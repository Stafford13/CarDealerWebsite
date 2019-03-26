using System.Collections.Generic;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();

        Car GetById(int CarId);
        void Insert(Car car);
        void Update(Car car);
        void Delete(int CarId);
    }
}
