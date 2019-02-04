using System;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class UserIO
    {
        public static void SplashScreen()
        {
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>>)(_B__A__T__T__L__E__S__H__I__P_)(<<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("<<>><<>><<>>)(PRESS__ANY__ENTER__TO__START)(<<>><<>><<>>");
            Console.WriteLine("\n \n");
            Console.ReadLine();
        }

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to Battleship");
            Console.WriteLine("\n");
        }

        public static Coordinate EnterCoordinates()
        {
            while (true)
            {
                Console.WriteLine("Please enter your coordinate (e.g. B5): ");
                string coords = Console.ReadLine();
                if (coords == null || coords == "")
                {
                    Console.WriteLine("WTF");
                    continue;
                }
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
                    if (coords[0] == xStr[i])
                    {
                        xCoord = i + 1;
                    }
                }

                if (xCoord > 10)
                {
                    Console.WriteLine("Excuse me? Try again.");
                    continue;
                }

                Coordinate xy = new Coordinate(xCoord, yCoord);

                return xy;
            }

        }
        public static void DisplayBoard(Board board)
        {
            string xStr = "ABCDEFGHIJ";
            char row = 'Z';
            ShotHistory displayShot = new ShotHistory();
            Console.WriteLine("   [1  2  3  4  5  6  7  8  9 10]");

            for (int x = 0; x < 10; x++)
            {
                row = xStr[x];
                Console.Write($"\n[{row}]");

                for (int y = 0; y < 10; y++)
                {
                        Coordinate coord = new Coordinate(x + 1, y + 1);
                        displayShot = board.CheckCoordinate(coord);
                    if (displayShot == ShotHistory.Hit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[H]");
                    }
                    if (displayShot == ShotHistory.Miss)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[M]");
                    }
                    if (displayShot == ShotHistory.Unknown)
                    {
                    Console.Write($"[ ]");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine("\n");
        }

        public static ShipDirection Direction()
        {
            while (true)
            {
                Console.WriteLine("Please enter the Ship direction (up, down, left, right): ");
                string direction = Console.ReadLine();
                switch (direction.ToUpper())
                {
                    case "UP":
                    case "U":
                        return ShipDirection.Up;
                    case "DOWN":
                    case "D":
                        return ShipDirection.Down;
                    case "LEFT":
                    case "L":
                        return ShipDirection.Left;
                    case "RIGHT":
                    case "R":
                        return ShipDirection.Right;
                }
            }
        }

        public static int Randomize(Player user1, Player user2)
        {
            Random Player = new Random();
            int random = Player.Next(1, 2);
            if (random == 1)
            {
                Console.WriteLine($"{user1.Name} goes first.");
                return random;
            }
            else
            {
                Console.WriteLine($"{user2.Name} goes second.");
                return random;
            }

        }

        public static bool VictoryAndGlory()
        {
            Console.WriteLine("You're a winnah, baby");
            Console.WriteLine("\n \n");
            while (true)
            {
                Console.WriteLine("Would you like to play again?");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "yes")
                {
                    Console.Clear();
                    return true;
                }
                if (input == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    return false;
                }
                else
                {
                    Console.WriteLine("Could you try that again? I didn't understand you. Try typing yes or no.");
                }
            }
        }

        public static void PlaceShips(Board board)
        {
            foreach (var item in Enum.GetValues(typeof(ShipType)))
            {
                while (true)
                {
                    Console.WriteLine($"\nPlace your {item}");

                    PlaceShipRequest request = new PlaceShipRequest
                    {
                        Coordinate = UserIO.EnterCoordinates(),
                        Direction = UserIO.Direction(),
                        ShipType = (ShipType)item, //set up loop to rotate current ship
                    };
                    ShipPlacement response = new ShipPlacement();
                    response = board.PlaceShip(request);
                    switch (response)
                    {
                        case ShipPlacement.NotEnoughSpace:
                            Console.Clear();
                            Console.WriteLine($"Could not place {item}: Not enough space.\nPlease try again.");
                            continue;
                        case ShipPlacement.Overlap:
                            Console.Clear();
                            Console.WriteLine($"Could not place {item}: Ship overlap.\nPlease try again");
                            continue;
                        case ShipPlacement.Ok:
                            break;
                    }
                    break;
                }
                Console.Clear();

            }

        }
        public static void DisplayShotStatus(Player user, FireShotResponse response)
        {
            switch (response.ShotStatus)
            {
                case ShotStatus.Invalid:
                    Console.WriteLine($"\n{response.ShotStatus}.");
                    break;
                case ShotStatus.Duplicate:
                    Console.WriteLine($"\n{response.ShotStatus}.");
                    break;
                case ShotStatus.Miss:
                    Console.WriteLine($"\n{response.ShotStatus}.");
                    break;
                case ShotStatus.Hit:
                    Console.WriteLine($"\n{response.ShotStatus}!");
                    break;
                case ShotStatus.HitAndSunk:
                    Console.WriteLine($"\n{response.ShotStatus}!!");
                    break;
                case ShotStatus.Victory:
                    Console.WriteLine($"\n{response.ShotStatus}!!!!\n{user.Name} has Won!!!!");
                    break;
            }
        }
        public static void TakingTurns(Player user1, Player user2)
        {
            Player currentPlayer = new Player();
            Player nextPlayer = new Player();
            FireShotResponse response;
            int flip = Randomize(user1, user2);
            do
            {

                if (flip == 1)
                {
                    currentPlayer = user1;
                    nextPlayer = user2;
                    flip = 2;
                }
                else
                {
                    currentPlayer = user2;
                    nextPlayer = user1;
                    flip = 1;
                }

                DisplayBoard(nextPlayer.Board);
                do
                {
                    //get coord for shot
                    Coordinate coord = EnterCoordinates();

                    //check result
                    response = nextPlayer.Board.FireShot(coord);
                    DisplayShotStatus(currentPlayer, response);

                }
                while (response.ShotStatus == ShotStatus.Invalid || response.ShotStatus == ShotStatus.Duplicate);
                ClearConsole($"Press any Key to end {currentPlayer.Name}'s turn");
            }
            while (response.ShotStatus != ShotStatus.Victory);

        }

        public static void ClearConsole(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Read();
            Console.Clear();
        }


        public static void User1(Player player)
        {
            Console.WriteLine("User 1. What is your name?");
            string name1 = Console.ReadLine();
            player.Name = name1;
        }

        public static void User2(Player player)
        {
            Console.WriteLine("User 2. What is your name?");
            string name2 = Console.ReadLine();
            player.Name = name2;
        }


    }
}

// If Else can be switch
// I use UserIO a lot, more so than actual input and output. Getting data and displaying data
// Workflow - 