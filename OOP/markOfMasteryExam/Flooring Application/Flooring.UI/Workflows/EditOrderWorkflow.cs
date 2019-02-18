﻿using System;
using Flooring.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models.Response;
using Flooring.Models.Interfaces;
using Flooring.BLL;
using System.Globalization;
using Flooring.Data;

namespace Flooring.UI.Workflows
{
    public class EditOrderWorkflow
    {
        IConsoleIO io = new ConsoleIO();
        ITaxRepository uo = new TaxListRepository();
        IProductRepository yo = new ProductListRepository();

        FlooringOrder newOrder = new FlooringOrder();
        DisplayOrderResponse response = new DisplayOrderResponse();

        public void Execute()
        {
            OrderManager manager = OrderManagerFactory.Create();

            Console.Clear();
            Console.WriteLine("Edit an order");
            Console.WriteLine("------------------------");
            bool isValidDate = false;
            DateTime orderDate = new DateTime();
            string date1 = "";
            while (isValidDate == false)
            {
                date1 = io.GetDateFromUser("Please provide a date");

                orderDate = DateTime.ParseExact(date1, "MMddyyyy", CultureInfo.GetCultureInfo("en-us"));

                if (orderDate <= DateTime.Today)
                {
                    Console.WriteLine("Date must be later than today");
                }
                else
                {
                    isValidDate = true;
                }
            }

            DisplayOrderResponse oldResponse = manager.LoadOrders(date1);

            foreach (FlooringOrder order in oldResponse.Orders)
            {
                io.DisplayOrderDetails(order);
            }

            int ordernumber = -1;
            bool isValidNumber = false;
            while (isValidNumber == false)
            {
                string orderstring = io.GetStringFromUser("Please enter an order number.");
                if (!int.TryParse(orderstring, out ordernumber))
                {
                    Console.WriteLine("This did not work, please enter a number");
                }
                else
                {
                    foreach (var item in oldResponse.Orders)
                    {
                        if (item.OrderNumber == ordernumber)
                        {
                            newOrder = item;
                        }
                    }
                    isValidNumber = true;
                }
            }
        
            Console.WriteLine("");
            string newName = PromptUser("What would you like to change your name to?");

            if (newName != "")
            {
                while (!newName.All(c => Char.IsLetterOrDigit(c) || c == ',' || c == '_' || c == '.'))
                {
                    Console.WriteLine("Names must include either letters, numbers, spaces, periods, or commas (or any combonation thereof)");
                    newName = PromptUser("What is your name?");
                }
                newOrder.CustomerName = newName;
            }

            List<FlooringTax> TaxList = uo.LoadTax();
            FlooringTax orderTax = new FlooringTax();
            bool isValidTax = false;
            while (isValidTax == false)
            {
                foreach (FlooringTax tax in TaxList)
                {
                    Console.WriteLine("  " + (TaxList.IndexOf(tax) + 1) + ". " + tax.StateAbbreviation);
                }
                Console.WriteLine("Order is currently in " + newOrder.State);
                string newState = PromptUser("Enter a new state or press enter to continue.");
                if (newState != "")
                { 
                    if (int.TryParse(newState, out int nation))
                    {
                        if (nation > 0 && nation <= TaxList.Count)
                        {
                            newOrder.OrderTax = TaxList[nation - 1];
                            isValidTax = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That state isn't in our region yet.");
                    }
                }
            }

            List<FlooringProduct> ProductList = yo.LoadProducts();
            FlooringProduct orderProduct = new FlooringProduct();
            bool isValidProduct = false;
            while (isValidProduct == false)
            {
                foreach (FlooringProduct prod in ProductList)
                {
                    Console.Write("  " + (ProductList.IndexOf(prod) + 1) + ". " + prod.ProductType);
                    Console.Write("   Cost per sqft $" + prod.CostPerSquareFoot);
                    Console.Write("   Cost for Labor per sqft $" + prod.LaborCostPerSquareFoot);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("You have already chosen " + newOrder.ProductType);
                string newProduct = PromptUser("Please specifiy a different product or press enter to continue");
                if (newProduct != "")
                {
                    if (int.TryParse(newProduct, out int supply))
                    {
                        if (supply > 0 && supply <= ProductList.Count)
                        {
                            newOrder.OrderProduct = ProductList[supply - 1];
                            isValidProduct = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That product isn't available yet.");
                    }
                }
            }

            decimal area1 = 0;
            bool isValidArea = false;
            while (isValidArea == false)
            {
                area1 = newOrder.Area;
                string area = PromptUser("Please enter a new area or press enter to continue");
              
                if (area != "")
                {
                    if (decimal.TryParse(area, out area1))
                    {
                        if (area1 < 100)
                        {
                            Console.WriteLine("You must enter a positive amount above 100");
                            Console.WriteLine("Please enter a valid square footage.");
                        }
                        else
                        {
                            newOrder.Area = area1;
                            isValidArea = true;
                        }
                    }
                }
            }

            //// Which type?
            ////EditOrderResponse response = manager.EditOrder();

            //ask user for order number
            //if order exisits - ask user for each piece of order data && display exisiting data
            //StreamWriter.WriteLine(order.CustomerName, FlooringTax.StateAbbreviation, FlooringProduct.ProductType, Order.Area);
            //if user enters new input for row, that will replace that specific data
            //if user presses Enter key without entering data - leave existing data in place

            //Only CustomerName, State, ProductType, Area can be changed
            //if state, productType, or Area changes -> order recalculated
            //Order date may NOT change

            Console.Clear();
            io.DisplayOrderDetails(newOrder);

            bool isSave = false;
            while (isSave == false)
            {
                string place = PromptUser("Would you like to place this order? Please enter yes or no");
                if (place == "yes")
                {
                    manager.EditOrder(date1, newOrder, oldResponse.Orders);
                    isSave = true;
                    // save final to file with approps date
                }
                else if (place == "no")
                {
                    isSave = true;
                    //return to main menu, maybe break?
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

            //private void newMethod(DisplayOrderResponse response)
            //{
            //    io.DisplayOrderDetails(response.orderDate);
            //}

            public string PromptUser(string s)
            {
                Console.WriteLine(s);
                return Console.ReadLine();

            }
        }
    }
