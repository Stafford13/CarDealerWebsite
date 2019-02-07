using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using LINQ;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //PrintAllProducts();
            //PrintAllCustomers();

            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            Exercise12();
            Exercise13();
            Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            List<Product> all = DataLoader.LoadProducts();
            var os = all.Where(things => things.UnitsInStock == 0);

            PrintProductInformation(os);
            //in the list of products where the units in stock == 0, that is equal to the variable which is being printed.
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            List<Product> all = DataLoader.LoadProducts();
            var os = all.Where(units => units.UnitsInStock != 0 && units.UnitPrice >= 3.0000M);

            PrintProductInformation(os);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            List<Customer> all = DataLoader.LoadCustomers();
            var wa = all.Where(units => units.Region == "WA");

        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            List<Product> all = DataLoader.LoadProducts();
            var query = from p in all
                        select new { ProductName = p.ProductName };
            all.Select(list => list.ProductName);
            foreach (var item in query)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            List<Product> all = DataLoader.LoadProducts();
            var query = from p in all
                        select new { ProductID = p.ProductID, ProductName = p.ProductName, Category = p.Category, UnitPrice = p.UnitPrice * 1.25M, UnitsInStock = p.UnitsInStock };
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in query)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            List<Product> all = DataLoader.LoadProducts();
            var queue = from p in all
                        select new { ProductName = p.ProductName.ToUpper(), Category = p.Category.ToUpper() };
            string line = "{0,-35} {1,-15}";
            Console.WriteLine(line, "Product Name", "Category");
            Console.WriteLine("==============================================================================");

            foreach (var product in queue)
            {
                Console.WriteLine(line, product.ProductName, product.Category);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            List<Product> all = DataLoader.LoadProducts();
            var queue = from p in all
                        select new { ProductID = p.ProductID, ProductName = p.ProductName, Category = p.Category, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock, ReOrder = (p.UnitsInStock < 3 == true) };
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6} {5, -6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "ReOrder");
            Console.WriteLine("==============================================================================");

            foreach (var product in queue)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.ReOrder);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            List<Product> all = DataLoader.LoadProducts();
            var variable = from p in all
                           select new { ProductID = p.ProductID, ProductName = p.ProductName, Category = p.Category, UnitPrice = p.UnitPrice, UnitsInStock = p.UnitsInStock, StockValue = Math.Round(p.UnitsInStock * p.UnitPrice) };
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6} {5, -5}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "Stock Value");
            Console.WriteLine("==============================================================================");

            foreach (var product in variable)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock, product.StockValue);

            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary> 
        static void Exercise9()
        {
            var allevens = DataLoader.NumbersA.Where(n => n % 2 == 0);

            foreach (var item in allevens)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            List<Customer> rain = DataLoader.LoadCustomers();
            var cust = from c in rain
                       select new
                       {
                           customer = c,
                           OrderTotal = c.Orders.Sum(o => o.Total)
                       };

            var whatever = cust.Where(c => c.OrderTotal < 500.00M);

            foreach (var customer in whatever)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.customer.CompanyName);
                Console.WriteLine(customer.customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.customer.City, customer.customer.Region, customer.customer.PostalCode, customer.customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.customer.Phone, customer.customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var threeodds = DataLoader.NumbersC.Where(n => n % 2 != 0).Take(3);

            foreach (var item in threeodds)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var threeodds = DataLoader.NumbersB.Take(3);

            foreach (var item in threeodds)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            List<Customer> all = DataLoader.LoadCustomers();
            var wa = all.Where(units => units.Region == "WA");

            foreach (var customer in wa)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", customer.Orders.Last().OrderID, customer.Orders.Last().OrderDate, customer.Orders.Last().Total);
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var lessthansix = DataLoader.NumbersC.TakeWhile(n => n <= 6);

            foreach (var item in lessthansix)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var dividethree = DataLoader.NumbersC.Where(n => n % 3 == 0 && n != 0);
            foreach (var item in dividethree)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var alphabet = DataLoader.LoadProducts().OrderBy(a => a.ProductName);

            PrintProductInformation(alphabet);
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var alphabet = DataLoader.LoadProducts().OrderByDescending(a => a.UnitsInStock);

            PrintProductInformation(alphabet);
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            var beta = DataLoader.LoadProducts().OrderBy(a => a.Category).ThenByDescending(c => c.UnitPrice);

            PrintProductInformation(beta);
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var backwardsb = DataLoader.NumbersB.Reverse();

            foreach (var item in backwardsb)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var all = DataLoader.LoadProducts();
            var result = from p in all
                         orderby p.Category, p.ProductName
                         group p by p.Category;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("==============================================================================");
                foreach (var product in group)
                {
                    Console.WriteLine(product.ProductName);
                }
                Console.WriteLine("==============================================================================");
            }
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var q = from c in customers
                    select new
                    {
                        CustomerName = c.CompanyName,
                        Years = from o in c.Orders
                                group o by o.OrderDate.Year into gYear
                                select new
                                {
                                    Year = gYear.Key,
                                    Monts = from o in gYear
                                            group o by o.OrderDate.Month into gMonth
                                            select new
                                            {
                                                Month = gMonth.Key,
                                            }
                                }
                    };
        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            var one = DataLoader.LoadProducts();
            var queue = from p in one
                        select new
                        { p.Category };
            var results = queue.Distinct();

            foreach (var item in results)
            {
                Console.WriteLine(item.Category);
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            var seveneightnine = DataLoader.LoadProducts().Any(n => n.ProductID == 789);
            Console.WriteLine(seveneightnine);
        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            var one = DataLoader.LoadProducts().Where(p => p.UnitsInStock == 0);
            var queue = from p in one
                        select new
                        { p.Category };
            var results = queue.Distinct();

            foreach (var item in results)
            {
                Console.WriteLine(item.Category);
            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            var one = DataLoader.LoadProducts();
            var queue = from p in one
                        select new
                        { p.Category };
            var results = queue.Distinct();

            var two = DataLoader.LoadProducts().Where(p => p.UnitsInStock == 0);
            var queue2 = from p in two
                         select new
                         { p.Category };
            var results2 = queue2.Distinct();
            var result = results.Except(results2);

            foreach (var item in result)
            {
                Console.WriteLine(item.Category);
            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var boop = DataLoader.NumbersA.Count(n => n % 2 != 0);

            Console.WriteLine(boop);

        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            var cats = DataLoader.LoadCustomers();
            var whatevs = from c in cats
                          select new
                          {
                              c.CustomerID,
                              count = c.Orders.Count()
                          };

            foreach (var customer in whatevs)
            {
                Console.WriteLine("==============================================================================");
                Console.Write(customer.CustomerID);
                Console.WriteLine("\t{0}", customer.count);
                Console.WriteLine("==============================================================================");
                Console.WriteLine();

            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            var one = DataLoader.LoadProducts();

            var queue = one.GroupBy(p => p.Category,
                (key, values) => new { Category = key, Count = values.Count() });

            foreach (var item in queue)
            {
                Console.WriteLine(item.Category + " " + item.Count);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {
            var three = DataLoader.LoadProducts();
            var queue = three.GroupBy(p => p.Category,
                (key, values) => new { Category = key, sum = values.Sum(p => p.UnitsInStock) });

            foreach (var item in queue)
            {
                Console.WriteLine(item.Category + " " + item.sum);
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            var beta = DataLoader.LoadProducts().OrderBy(a => a.Category).ThenBy(c => c.UnitPrice);
            var result = from p in beta
                         orderby p.Category, p.UnitPrice
                         group p by p.Category;

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");

            foreach (var item in result)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(line, item.First().ProductID, item.First().ProductName, item.First().Category,
                        item.First().UnitPrice, item.First().UnitsInStock);

            }
            Console.WriteLine("==============================================================================");

        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            var beta = DataLoader.LoadProducts();
            var result = from p in beta
                         group p by p.Category into query
                         select new
                         {
                             Category = query.Key,
                             avg = query.Average(p => p.UnitPrice)
                         };
            result = result.OrderByDescending(p => p.avg).Take(3);

            foreach (var item in result)
            {
                Console.WriteLine("{0,-15} {1, -6:c}", item.Category, item.avg);
            }


            //string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            //Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");

            //foreach (var item in result)
            //{
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine(line, item.ProductID, item.ProductName, item.Category,
            //            item.UnitPrice, item.UnitsInStock);

            //}
            //Console.WriteLine("==============================================================================");

            ////descending
        }
    }
}
