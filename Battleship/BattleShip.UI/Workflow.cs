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
            Coordinate yx = UserIO.EnterCoordinates();

            //        //start menu/create splashscreen

            //        //start method
            //        (UserIO.WelcomeUser)

            //        //start User1Method

            //        UserIO.GetName1(name1) = new GetName1();
            //        UserIO.GetName2(name2) = new GetName2();
            //        Board board1 = new Board();
            //        Board board2 = new Board();

            //        (UserIO.GetName1)
            //            (shipPlacement)(shipType)(ship)(5, 4, 3, 2, 1)
            //            //place ship (until all ships are printed)
            //            (UserIO.EnterCoordinates)
            //            //Coordinate?
            //            ShipDirection.cs
            //        //What direction?
            //        //else if (all ships have not been placed) loop back to place ship;

            //        //assign to user1

            //        Console.WriteLine("Press any key, and pass to User 2.");
            //        Console.ReadLine();
            //        Console.Clear();
            //        //else if (all ships have been placed) (end #2)


            //        //Start User2Method

            //        (UserIO.GetName2)
            //            (ShipPlacement.ShipPlacement)(ShipType.ShipType)(Ship.Ship)(5, 4, 3, 2, 1)
            //            //place ship (1 - 5)
            //            UserIO.EnterCoordinates;
            //        //Coordinate?
            //        ShipDirection.ShipDirection;
            //        //What direction?
            //        //else if (all ships not been placed) loop back to place ship;

            //        //assign to user2

            //        Console.WriteLine("Press any key, and pass to User 2.");
            //        Console.ReadLine();
            //        Console.Clear();

            //        (UserIO.Randomize)

            //        Player1Method
            //        {
            //            Console.WriteLine("Press any key to start your turn.");
            //            Console.ReadLine();
            //            //player1 and board2
            //            while (true)
            //            {
            //                (UserIO.EnterCoordinats)(Coordinate.Equals)(loop for ships)
            //                    //ask player1 for shot coordinate (trap user in while loop until valid) (#5)
            //                    (ShotStatus method) 
            //            //validate shot && check shotType 
            //            (ShotHistory method)
            //            //display hit, miss, or invalid
            //            } 
            //            else
            //            {
            //                //did player1 win? if statement (#6)
            //                //if (all 5 battleships sunk) 
            //                //go to Victory message
            //                //if (not all 5 battleships sunk)
            //                Console.WriteLine("Press any key to end your turn");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }

            //        Player2Method
            //      {
            //            Console.WriteLine("Press any key to start your turn.");
            //            Console.ReadLine();
            //            //player2 and board1
            //            while (true)
            //            {
            //                (UserIO.EnterCoordinates)(loop for ships)
            //                    //ask player2 for shot coordinate (trap user in while loop until valid) (#8)
            //                    (ShotStatus method) 
            //            //validate shot && check shotType 
            //            (ShotHistory method) = int history
            //            //display hit, miss, or invalid
            //            }
            //            else
            //            {
            //                //did player2 win? if statement (#9)
            //                //if (all 5 battleships sunk)
            //                // go to Victory message
            //                //else if (not all 5 battleships sunk) 
            //            }
            //                Console.WriteLine("Press any key to end your turn");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }

            //        UserIO.VictoryAndGlory();

            //    }
            //}
        }
    }
}