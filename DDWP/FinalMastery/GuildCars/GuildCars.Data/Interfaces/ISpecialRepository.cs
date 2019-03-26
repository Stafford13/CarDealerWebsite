using System;
using System.Collections.Generic;
using System.Text;
using GuildCars.Models.Tables;

namespace GuildCars.Data.Interfaces
{
    public interface ISpecialRepository
    {
        List<Special> GetAll();
    }
}
