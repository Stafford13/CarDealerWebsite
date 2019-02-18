using Flooring.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Data
{
    public class OrderFileRepository
    {
        public List<FlooringOrder> LoadOrders(string date)
        {
            List<FlooringOrder> orders = new List<FlooringOrder>();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader($"Orders_{date}.txt");
                string row = "";
                sr.ReadLine();
                while ((row = sr.ReadLine()) != null)
                {
                    orders.Add(OrderMapper.ToOrder(row, date));
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
