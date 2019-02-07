using System;
namespace Factorizor.BLL
{
    public class PrimeCheck
    { 
    public bool PrimeChecker()
            {
                int num;
                int count = 0;
                for (int i = num - 1; i > 0; i--)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                    else if (count > 1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }

// needs a reference for number (back to the user generated number?