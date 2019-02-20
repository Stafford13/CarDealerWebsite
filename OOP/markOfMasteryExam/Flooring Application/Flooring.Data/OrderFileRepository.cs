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
    public class OrderFileRepository : IRepository
    {
        protected List<FlooringOrder> orders;
        private readonly string FILENAME;

        public OrderFileRepository(string filename)
        {
            FILENAME = filename;
            LoadOrders(filename);
        }

        public int nextOrderNumber(string date)
        {
            int id = 0;
            foreach (FlooringOrder order in orders)
            {
                if (order.OrderNumber > id)
                {
                    id = order.OrderNumber;
                }
            }
            id = id + 1;
            return id;
        }

        // CREATE
        public void Create(string datestring, FlooringOrder newOrder)
        {
            if (!File.Exists(FILENAME))
            {
                File.Create(FILENAME).Close();
            }

            newOrder.OrderNumber = nextOrderNumber("");
            newOrder.date = DateTime.Now;
            orders.Add(newOrder);
            SaveOrders();
            //return newOrder;
        }

        // READALL
        public List<FlooringOrder> ReadAll()
        {
            return orders;
        }

        // READBY
        public virtual FlooringOrder ReadById(int id)
        {

            foreach (FlooringOrder order in orders)
            {
                if (order.OrderNumber == id)
                {
                    return order;
                }
            }
            return null;
        }
        // UPDATE
        public void Update(string datestring, FlooringOrder newOrder, List<FlooringOrder> List)
        {
            // Loop until find the index, and modify way
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderNumber != newOrder.OrderNumber) continue;
                orders[i] = newOrder;
                break;
            }
            SaveOrders();
            //int index = _orders.FindIndex((FlooringOrder c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _orders[index] = newFlooringOrderInfo;
            //}


        }
        // DELETE
        public void Delete(DateTime orderDate, int orderNumber)
        {
            orders.RemoveAll((FlooringOrder orderInfo) => orderInfo.OrderNumber == orderNumber);
            SaveOrders();
        }

        /// <summary>
        /// Saving to a text file what is in a order list
        /// </summary>
        private void SaveOrders()
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(FILENAME);
                sw.Write("OrderNumber||CustomerName||State||TaxRate||ProductType||Area||CostPerSquareFoot||LaborCostPerSquareFoot||MaterialCost||LaborCost||Tax||Total");

                foreach (FlooringOrder orders in orders)
                {
                    sw.WriteLine(OrderMapper.toStringCSV(orders));
                    sw.Flush();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                if (sw != null) sw.Close();
            }

        }

        public List<FlooringOrder> LoadOrders(string datestring)
        {
            List<FlooringOrder> orders = new List<FlooringOrder>();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(FILENAME);
                string row = "";
                sr.ReadLine();
                while ((row = sr.ReadLine()) != null)
                {
                    orders.Add(OrderMapper.ToOrder(row));
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("File was not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return orders;
        }
        

    }
}

