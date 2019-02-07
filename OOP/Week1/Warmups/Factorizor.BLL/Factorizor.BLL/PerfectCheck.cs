using System;
namespace Factorizor.BLL
{
    public class PerfectCheck
    {
        public bool PerfectChecker()
        {
            int sum = 0;
            int num;

            for (int i = num - 1; i > 0; i--)
            {

                if (sum == num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

// needs a number to reference the user input