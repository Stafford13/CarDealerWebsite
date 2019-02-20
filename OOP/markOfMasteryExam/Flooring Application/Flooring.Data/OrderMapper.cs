using Flooring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Data
{
    public class OrderMapper
    {
        public static string ToString(FlooringOrder order)
        {
            return $"{order.OrderNumber}|{order.date}||{order.CustomerName}||{order.State}||{order.TaxRate}||{order.ProductType}||{order.Area}||{order.CostPerSquareFoot}||{order.LaborCostPerSquareFoot}||{order.MaterialCost}||{order.LaborCost}||{order.Tax}||{order.Total}";
        }

        public static FlooringOrder ToOrder(string row)
        {
            FlooringOrder o = new FlooringOrder();
            string[] fields = row.Split(new string[] { "||" }, StringSplitOptions.None);

            o.OrderNumber = int.Parse(fields[0]);
            o.CustomerName = fields[1];
            o.State = fields[2];
            o.TaxRate = decimal.Parse(fields[3]);
            o.ProductType = fields[4];
            o.Area = decimal.Parse(fields[5]);
            o.CostPerSquareFoot = decimal.Parse(fields[6]);
            o.LaborCostPerSquareFoot = decimal.Parse(fields[7]);
            o.MaterialCost = decimal.Parse(fields[8]);
            o.LaborCost = decimal.Parse(fields[9]);
            o.Tax = decimal.Parse(fields[10]);
            o.Total = decimal.Parse(fields[11]);
            //o.date = DateTime.Parse(fields[12]);
            return o;
        }

        internal static char toStringCSV(FlooringOrder orders)
        {
            throw new NotImplementedException();
        }
    }
}
