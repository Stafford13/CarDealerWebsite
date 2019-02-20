using Flooring.Models;
using Flooring.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Data
{
    public class OrderTestRepository : IRepository
    {
        private static FlooringOrder _order = new FlooringOrder
        {
            OrderNumber = 1,
            date = DateTime.Today,
            CustomerName = "Acme",
            Area = 100,
            OrderTax = new FlooringTax
            {
                StateAbbreviation = "OH",
                StateName = "Ohio",
                TaxRate = 10
            },
            OrderProduct = new FlooringProduct
            {
                ProductType = "Wood",
                CostPerSquareFoot = 5.15m,
                LaborCostPerSquareFoot = 6m
            },
        };

        public int nextOrderNumber(string date)
        {
            int result = 2;
            return result;
        }

        public void Create(string datestring, FlooringOrder newOrder)
        {
            List<FlooringOrder> orders = LoadOrders(datestring);
            orders.Add(newOrder);
            SaveOrder(orders, datestring);
        }

        public void Delete(DateTime orderDate, int orderNumber)
        {
            throw new NotImplementedException();
        }

        public List<FlooringOrder> LoadOrders(string date)
        {
            List<FlooringOrder> orders = new List<FlooringOrder>();
            orders.Add(_order);
            return orders;
        }

        public void Update(string datestring, FlooringOrder newOrder, List<FlooringOrder> List)
        {
            return;
            //throw new NotImplementedException();
        }

        private void SaveOrder(List<FlooringOrder> order, string date)
        {
            return;
        }
    }
}
