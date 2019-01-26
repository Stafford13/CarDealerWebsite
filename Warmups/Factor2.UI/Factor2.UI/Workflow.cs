using System;
using Factor_Run.UI;
using Factorizor.BLL;

namespace Factor_Run.UI
{
    public class Workflow
    {
            public void Run()
            {
            // declare variables
                    int number = 0;
            // user input number
            int input = UserIO.UserInput();
            // display factor
            int xmen = Library.(input);
            // display if perfect or not
            int perfect = UserIO.PerfectChecker();
            // display if prime or not
            int prime = UserIO.PrimeChecker();
           
        }
        // NO calculations
    }



}

