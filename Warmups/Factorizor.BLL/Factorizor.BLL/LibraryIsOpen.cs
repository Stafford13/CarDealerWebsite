using System;
using Factorizor.BLL;
using Factor_Run.UI

namespace Factorizor.BLL
{
    public class Library
    { 

    //factor finder method
    //rturns an array containing the factors of a given number
    public string FactorFinder(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {

                if (num % i == 0)
                {
                    return (num + (i + " "));
                }
                else
                {
                    return "No Factors";
                }
            }

        }

    }
}



