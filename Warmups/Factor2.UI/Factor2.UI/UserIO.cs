using System;
using Factorizor.BLL;

namespace Factor_Run.UI
{
    public class UserIO
    {
        public int UserInput()
        {
            Console.WriteLine("Hello user, choose a number.");
            string number = Console.ReadLine();
            Console.WriteLine($"You've chosen {int.Parse(number)}");
        }

        public string Fack()
        {
        Console.WriteLine(Library.FactorFinder());
        Console.WriteLine(PerfectCheck.PerfectChecker());
        Console.WriteLine(PrimeCheck.PrimeChecker());
        }
    }
}

