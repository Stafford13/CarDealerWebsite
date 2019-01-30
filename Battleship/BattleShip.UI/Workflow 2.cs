using System;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class Workflow_2
    {
        public void Workflow2()
        {
            //Board board1 = new Board();
            //Board board2 = new Board();
            //Player player1 = new Player();
            //Player player2 = new Player();

            //UserIO.SplashScreen();
            //do
            //{
            //    while (true)
            //    {
            //        UserIO.WelcomeUser();

            //        //Player1
            //        UserIO.User1();
            //        UserIO.PlacingShips(board1);
            //        //place Battleship on board 1
            //        //Validate coordinate loop
            //        //ship direction - valid?
            //        //place carrier on board 1
            //        //Validate coordinate loop
            //        //ship direction - valid?
            //        //place Crusier on board 1
            //        //Validate coordinate loop
            //        //ship direction - valid?
            //        //place Destroyer on board 1
            //        //Validate coordinate loop
            //        //ship direction - valid?
            //        //place Submarine on board 1
            //        //Validate coordinate loop
            //        //ship direction - valid?
            //        //save positions to board 1
            //        //press key and clear

            //        //Player2
            //        UserIO.User2();
            //        UserIO.PlacingShips(board2);
            //        //place Battleship on board 2
            //        //Validate coordinate loop
            //        //ship direction
            //        //place carrier on board 2
            //        //Validate coordinate loop
            //        //ship direction
            //        //place Crusier on board 2
            //        //Validate coordinate loop
            //        //ship direction
            //        //place Destroyer on board 2
            //        //Validate coordinate loop
            //        //ship direction
            //        //place Submarine on board 2
            //        //Validate coordinate loop
            //        //ship direction
            //        // save positions to board 2
            //        //press key and clear

            //        UserIO.Randomize();

            //        while (true)
            //        {
            //            UserIO.PlayerOne();
            //            UserIO.DisplayBoard();

            //            //call coordinate to make shot
            //            // Loop validate shot end-loop
            //            //check shot status
            //            //check shot history
            //            // (if victory(hit and sunk 5 ships) break out to victory)
            //            // (else continue)

            //            UserIO.DisplayBoard();
            //            //player2 and opposite board (w/ shot history)
            //            //call coordinate to make shot
            //            // loop validate shot end-loop
            //            //check shot status
            //            //check shot history
            //            // (if victory break out to victory method)
            //            // (else continue with loop)
            //        }

            //        UserIO.VictoryAndGlory();
            //    }
            //    //};
            //}
    }
    }
}


//splash

//while (true)
//welcome user
//user1.board = new Board();
//user2.board = new Board();
//user1.enemyPlayer = user2
//user2.enemyPlayer = user1

// -> get user1 name
//DisplayBoard(1)
//PlaceShipRequest
// -> UserIO.EnterCoordinates() ask for coordinates
// -> ask for ship direction
//ShipPlacement
//clear console

// -> get user2 name
//DisplayBoard(2)
//PlaceShipRequest
// -> UserIO.EnterCoordinates() ask for coordinates
// -> ask for ship direction
//ShipPlacement
//clear console

//determine who goes first

    //while
//player1 + enemyPlayer.board
//fire shot
// -> UserIO.EnterCoordinates() ask Player1 for coordinates
//FireShotResponse
    //Shot History
    //Shot Status
        // if = victory, break
    //else if (clear console and continue)

//player2 + enemyPlayer.board
//fire shot
// -> UserIO.EnterCoordinates() ask Player2 for coordinates
//FireShotResponse
    //Shot History
    //Shot Status = victory, break
    //else if (clear console and continue)

//victory message

//play again?
    // -> get response yes, continue
    // -> get response no, quit