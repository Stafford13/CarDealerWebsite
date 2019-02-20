using System;
using System.Collections.Generic;
using Flooring.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models.Interfaces
{
    public interface IRepository
    {
        int nextOrderNumber(string date);
        
        //R
        List<FlooringOrder> LoadOrders(string datestring);
        //CRUD
        //create order
        void Create(string datestring, FlooringOrder newOrder);
        //update order
        void Update(string datestring, FlooringOrder newOrder, List<FlooringOrder> List);
        //delete order
        void Delete(DateTime orderDate, int orderNumber);
    }
}
