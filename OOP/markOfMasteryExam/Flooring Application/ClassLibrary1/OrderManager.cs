using Flooring.Models;
using Flooring.Models.Interfaces;
using Flooring.Models.Response;
using Flooring.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.BLL
{
    public class OrderManager
    {
        private List<FlooringOrder> orders = new List<FlooringOrder>();
        private ITaxRepository _taxRepo = new TaxListRepository();
        private IProductRepository _productRepo = new ProductListRepository();
        private IRepository _orderRepository;

        public OrderManager(IRepository displayOrderRepository)
        {
            _orderRepository = displayOrderRepository;
            
        }

        public List<FlooringProduct> GetProducts()
        {
            List<FlooringProduct> products = _productRepo.LoadProducts();
            return products;
        }

        public NextOrderNumberResponse NextOrderNumber(string date)
        {
            NextOrderNumberResponse response = new NextOrderNumberResponse();
            response.OrderNumber = _orderRepository.nextOrderNumber(date);
            return response;
        }

        public DisplayOrderResponse LoadOrders(string date)
        {
            DisplayOrderResponse response = new DisplayOrderResponse();

            response.Orders = _orderRepository.LoadOrders(date);


            return response;
        }
        public void AddOrder(string datestring, FlooringOrder newOrder)
        {
           
            _orderRepository.Create(datestring, newOrder);
            return;
        }

        public void EditOrder(string datestring, FlooringOrder newOrder, List<FlooringOrder> List)
        {
            _orderRepository.Update(datestring, newOrder, List);
            return;
        }

        public void DeleteOrder(string datestring, FlooringOrder newOrder, List<FlooringOrder> List)
        {
            _orderRepository.Delete(datestring, newOrder, List);
            return;
        }
    }
}

