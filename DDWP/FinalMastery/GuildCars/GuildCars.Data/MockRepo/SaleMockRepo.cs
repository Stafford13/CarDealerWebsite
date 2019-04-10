using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.MockRepo
{
    public class SaleMockRepo
    {
        private static List<Sale> _sales;
        public Sale GetById(int id)
        {
            return _sales.FirstOrDefault(c => c.SaleId == id);
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _sales;
        }
    }
}
