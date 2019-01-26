using System;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class UserIO
    {
        private static void SplashScreen()
        {
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>>)(_B__A__T__T__L__E__S__H__I__P_)(<<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>>)(PRESS__ANY__KEY__TO__START)(<<>><<>><<>>");
            Console.WriteLine("\n \n");
            Console.ReadLine();
        }

        public string WelcomeUser()
        {
            Console.WriteLine("Welcome to Battleship");
        }

        public string GetName1()
        {
            Console.WriteLine("User 1. What is your name?");
            string name1 = Console.ReadLine();
        }

        public string GetName2()
        {
            Console.WriteLine("User 2. What is your name?");
            string name2 = Console.ReadLine();
        }

        public static Coordinate EnterCoordinates()
        {
            while (true)
            {
                Console.WriteLine("Please enter your coordinate (e.g. B5): ");
                string coords = Console.ReadLine();
                coords = coords.ToUpper();

                string xStr = "ABCDEFJHIJKLMNOPQRSTUVWXYZ";
                int xCoord = 0;
                int yCoord = 0;
                if (int.TryParse(coords.Substring(1), out yCoord))
                {
                    if (yCoord < 1 || yCoord > 10)
                    {
                        Console.WriteLine("Wrong. Try again.");
                        continue;
                    }
                }

                for (int i = 0; i < xStr.Length; i++)
                {
                    if (xCoord > 10)
                    {
                        continue;
                    }
                    else {
                        if (coords[0] == xStr[i])
                        {
                            xCoord = i + 1;
                        }
                        else
                        {
                            Console.WriteLine("Excuse me? Try again.");
                            continue;
                        }
                    }

                }
                Coordinate xy = new Coordinate(xCoord, yCoord);

                return xy;
            }
         }

            public static void DisplayBoard(Board board)
            {
                for (int x = 0; x < 11; x++)
                {
                for (int y = 0; y < 11; y++)
                {
                    if (x == 0 && y == 0)
                    {
                        Console.Write("[ ]");
                    }

                }
                }
            }

            

            public string Randomize()
            {
                Random Player = new Random();
                int random = Player.Next(1, 2);
                Console.WriteLine($"Player {Player} goes first.");
                if (random == 2)
                {
                    //Player1Method
                }
                else
                {
                    //Player2Method
                }
            }

            public static string VictoryAndGlory()
            {
                Console.WriteLine("You're a winnah, baby");
                Console.WriteLine("\n \n");
                Console.WriteLine("Would you like to play again?");
                string input = Console.ReadLine().ToLower;

                while (true)
                {
                    if (input == "yes")
                    {
                        return WelcomeUser();
                    }
                    else if (input == "no")
                    {
                        Console.WriteLine("Thanks for playing!");
                        Environment.Exit(0);
                    }
                    else
                    { 
                    Console.WriteLine("Could you try that again? I didn't understand you.");
                        continue;
                    }
                }
            }
        }
    }

