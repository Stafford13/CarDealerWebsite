using System;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class Workflow
    {
        public void Run()
        {

            UserIO.SplashScreen();
            UserIO.WelcomeUser();
        
            //Players and Boards

            Player player1 = new Player();
            Player player2 = new Player();
            Board board1 = new Board();
            Board board2 = new Board();

            //User1SetUp
            UserIO.PlacingShips.board1();
            UserIO.PlacingShips(ShipType.Battleship);
            //place ship (until all ships are printed)
            (UserIO.EnterCoordinates)
                        ShipDirection
            Console.WriteLine("Press any key, and pass to User 2.");
            Console.ReadLine();
            Console.Clear();

            //User2SetUp
            (UserIO.GetName2)
                (ShipPlacement.ShipPlacement)(ShipType.ShipType)(Ship.Ship)(5, 4, 3, 2, 1)
                        UserIO.EnterCoordinates;
            ShipDirection.ShipDirection;
            Console.WriteLine("Press any key, and pass to User 2.");
            Console.ReadLine();
            Console.Clear();

            //Randomize
            (UserIO.Randomize)

            //Player1GamePlay
            Console.WriteLine("Press any key to start your turn.");
                Console.ReadLine();
                //playerX and boardY
            
                    (UserIO.EnterCoordinates)(Coordinate.Equals)(loop for ships)
                        //ask player1 for shot coordinate (trap user in while loop until valid) (#5)
                        (ShotStatus method) 
                        //validate shot && check shotType 
                        (ShotHistory method)
                        //display hit, miss, or invalid
                         
                        //did player1 win? if statement (#6)
                        //if (all 5 battleships sunk) 
                        //go to Victory message
                        //if (not all 5 battleships sunk)
                    
                
                    Console.WriteLine("Press any key to end your turn");
                    Console.ReadLine();
                    Console.Clear();

                


                Player2Method;
                  {
                Console.WriteLine("Press any key to start your turn.");
                Console.ReadLine();
                //playerY and boardX
                while (true)
                {
                    (UserIO.EnterCoordinates)(loop for ships)
                        //ask player2 for shot coordinate (trap user in while loop until valid) (#8)
                        (ShotStatus method) 
                        //validate shot && check shotType 
                        (ShotHistory method) = int history
                        //display hit, miss, or invalid

                        else
                        {
                    //did player2 win? if statement (#9)
                    //if (all 5 battleships sunk)
                    // go to Victory message
                    //else if (not all 5 battleships sunk) 
                }
                Console.WriteLine("Press any key to end your turn");
                Console.ReadLine();
                Console.Clear();
            }

            UserIO.VictoryAndGlory();

        }
    }
}