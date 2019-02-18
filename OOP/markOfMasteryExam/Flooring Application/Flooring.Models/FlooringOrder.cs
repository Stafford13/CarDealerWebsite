using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public class FlooringOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string State
        {
            get
            {
                return OrderTax.StateAbbreviation;
            }
            set
            { }
        }
        public decimal TaxRate
        {
            get
            {
                return OrderTax.TaxRate;
            }
            set
            { }
        }
        public string ProductType
        {
            get
            {
                return OrderProduct.ProductType;
            }
            set
            { }
        }
        public decimal Area { get; set; }
        public decimal CostPerSquareFoot
        {
            get
            {
                return OrderProduct.CostPerSquareFoot;
            }
            set
            { }
        }
        public decimal LaborCostPerSquareFoot
        {
            get
            {
                return OrderProduct.LaborCostPerSquareFoot;
            }
            set
            { }
        }
        public decimal MaterialCost
        {
            get
            {
                return Area * CostPerSquareFoot;
            }
            set { }
        }
        public decimal LaborCost
        {
            get
            {
                return Area * LaborCostPerSquareFoot;
            }
            set { }
        }
        public decimal Tax
        {
            get
            {
                return (MaterialCost + LaborCost) * (TaxRate / 100);
            }
            set { }
        }
        public decimal Total
        {
            get
            {
                return MaterialCost + LaborCost + Tax;
            }
            set { }
        }

        public DateTime date { get; set; }
        public FlooringTax OrderTax { get; set; }
        public FlooringProduct OrderProduct { get; set; }


        //finish order mapper
    }
}
