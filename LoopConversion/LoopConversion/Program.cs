using System;

namespace LoopConversion
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DoFirstLoop();
            DoSecondLoop(100);
            Console.ReadKey();
        }

        static void DoFirstLoop()
        {
            // Change this for loop into a while.
            int i = 0;
            while (i < 100)
            {
                if ((i > 17 && i % 2 == 0)
                    || i > 85)
                {
                    Console.WriteLine($"i == {i}");
                }
                i++;
            }
        }

        static void DoSecondLoop(int n)
        {
            // Change this while loop into a for.
            for (n = 100;n > 0;n--)
            {
                int modThree = n % 3;
                switch (modThree)
                {
                    case 0:
                        Console.WriteLine($"3 divides eveningly into {n}.");
                        break;
                    case 1:
                        Console.WriteLine($"Dividing 3 into {n} leaves 1.");
                        break;
                    case 2:
                        Console.WriteLine($"Dividing 3 into {n} leaves 2.");
                        break;
                    default:
                        Console.WriteLine("This should never happen!");
                        break;
                }

            }
        }
    }
}
