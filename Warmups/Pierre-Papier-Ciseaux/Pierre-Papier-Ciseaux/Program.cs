using System;

namespace Pierre_Papier_Ciseaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user. Let's play a game");
            Console.WriteLine("How many rounds of Rock, Paper, Scissors would you like to play? Please choose between 1 and 10.");
            string str = Console.ReadLine();
            int x = Int32.Parse(str);

            if (x <= 0 && x > 10)
            {
                Console.WriteLine("This isn't what I asked for! Try again, gurl.");
            }
            else if (x >= 1 && x < 10)
            {
                Console.WriteLine($" You will play for {x} rounds.");
            }

            for (int i = 1; i <= str.Length; i++)

                if (i <= str.Length)
                {
                    for (int j = 0; j < x; i++)
                    {
                        Random handThrown = new Random();
                        int throwHands = handThrown.Next(2) + 1;

                        Console.WriteLine("Please choose your weapon of choice: Rock (1), Paper (2), or Scissors (3)");
                        string line = Console.ReadLine();
                        Console.WriteLine($"So, you've chosen {line}. Now I will choose.");
                        Console.WriteLine($"I have chosen {throwHands}.");
                        int y = Int32.Parse(line);

                        if (throwHands == y)
                        {
                            int r = Int32.Parse(j);
                            Console.WriteLine("Well, look at that. We tied!");
                        }
                        else if (throwHands < y)
                        {
                            Console.WriteLine("Looks like someone's lucky. You win this round.");
                        }
                        else if (throwHands > y)
                        {
                            Console.WriteLine("Sorry, not sorry. I win this round.");
                        }
                    }
                    Console.WriteLine("Let's go again, shall we?");
                    int wins = r;
                    int lose = t;
                    int ties = h;
                }
                else if (i > str.Length)
                {
                Console.WriteLine($"You ended up with {ties} ties, {wins} wins, and {lose} losses.");

                    if (wins > lose)
                    {
                        Console.WriteLine("You're a winner, baby.");
                        Exit();
                    }
                    else if (lose < wins)
                    {
                        Console.WriteLine("Looks like both your rock and your paper couldn't cut it.");
                        Exit();
                    }
                    else
                    {
                        Console.WriteLine("Flippty flop, neither of us are on top");
                        Exit();
                    }
                }
        }
            static void Exit()
            {
                Console.WriteLine("Would you like to play again? Please press y or n");
                if (Console.ReadLine().Equals("y"))
                {
                    Console.WriteLine("Here we go!");
                    Main();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
            }
        }
    }

// Computer asks how many rounds the user would like to play between 1 and 10
//  if user says something else, print error message then quit program
// 
// FOR EACH ROUND:
// Computer asks user for input (1 - Rock, 2 - Paper, 3 - Scissors)
// Choose 1-3
// If loop (calls methods, like the practice.sln
// Random r = new Random():
// int choice = r.Next(3)+1;
//
// Console.WriteLine("Please choose rock (1), paper (2), or scissors (3)");   
// after asking, the comp randomly chooses, and displays tie, user win, or 
// comp win
// 
// Comp keeps track of ties, wins, and losses
// Create three variables to keep track of these items and updately them 
// correctly after every round 
// 
// comp must display the number of wins, ties, and losses && display winner based
// on who won more rounds
// 
// After a winner has been declared, the program must ask the user if they want to 
// play again
// 
//  If (true = Y) - starts over asking how many rounds the user would like to play
//    
// Ask for # of rounds (1-10)
//    
//    if (1-10)
//        for (n times)
//           Ask user to Pick 1 -3  
//          Randomly generate (1-3)
//          based on format - determine (tie, user win, comp win) = t
//          (keep track of all of i) = t
//        after (n) times
//          display t
//   else if (v<1 && v>10 || v=="string")
//
//define lose, win, and tie variables
//increase wins and losses?
//somehow loop back into it