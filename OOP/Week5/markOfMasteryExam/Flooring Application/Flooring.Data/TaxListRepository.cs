using System;
using Flooring.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;
using System.IO;

namespace Flooring.Data
{
    public class TaxListRepository : ITaxRepository
    {
        public List<FlooringTax> LoadTax()
        {
            List<FlooringTax> taxes = new List<FlooringTax>();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader("Taxes.txt");
                sr.ReadLine();
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    FlooringTax t = TaxMapper.ToTax(row);
                    taxes.Add(t);
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine("File was not found");
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return taxes;
        }
    }
}
