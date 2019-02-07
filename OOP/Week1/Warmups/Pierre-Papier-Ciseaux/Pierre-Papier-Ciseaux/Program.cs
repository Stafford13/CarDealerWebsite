using System;

namespace Pierre_Papier_Ciseaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user. Let's play a game");
            int t = 0;
            int w = 0;
            int l = 0;

            while (true)
            {
                Console.WriteLine("Would you like to play?");
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Rounds();
                }
                else if (input == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
            void Rounds()
            {
                while (true)
                {
                    Console.WriteLine("How many rounds of Rock, Paper, Scissors would you like to play? Please choose between 1 and 10.");
                    int rounds = int.Parse(Console.ReadLine());
                    if (rounds > 0 && rounds < 11)
                    {
                        PlayGame(rounds);
                    }
                    else
                    {
                        Console.WriteLine("This isn't what I asked for! Try again, gurl");
                    }
                }
            }

            void PlayGame(int rounds)
            {
                for (int i = 1; i <= rounds; i++)
                {
                    Random handThrown = new Random();
                    int throwHands = handThrown.Next(2) + 1;

                    Console.WriteLine("Please choose your weapon of choice: Rock (1), Paper (2), or Scissors (3)");
                    string line = Console.ReadLine();
                    //Console.WriteLine($"So, you've chosen {line}. Now I will choose.");
                    //Console.WriteLine($"I have chosen {throwHands}.");
                    int y = Int32.Parse(line);

                    if (throwHands == y)
                    {
                        Console.WriteLine("Well, look at that. We tied!");
                        t++;
                    }
                    else if (throwHands < y)
                    {
                        Console.WriteLine("Looks like someone's lucky. You win this round.");
                        w++;
                    }
                    else if (throwHands > y)
                    {
                        Console.WriteLine("Sorry, not sorry. I win this round.");
                        l++;
                    }

                    if (i < rounds)
                    {
                        Console.WriteLine("Let's go again, shall we?");
                    }
                    else 
                    {
                        Ending();
                    }
                }
                
            }
            void Ending()
            {
                Console.WriteLine($"You ended up with {t} ties, {w} wins, and {l} losses.");

                if (w > l)
                {
                    Console.WriteLine("You're a winner, baby.");
                }
                else if (l > w)
                {
                    Console.WriteLine("Looks like both your rock and your paper couldn't cut it.");
                }
                else if (l == w)
                {
                    Console.WriteLine("Flippty flop, neither of us are on top");
                }
                    PlayAgain();

            }

            void PlayAgain()
            {
                Console.WriteLine(" Would you like to play again?");
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Rounds();
                }
                else if (input == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}        

// The final W, T , L loops over into the next game...
// Feel free to return out of methods to main method
// Fix this so that it resets number of wins etc. every time




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