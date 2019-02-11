using System;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using BattleShip.UI;

namespace BattleShip.UI
{
    public class Workflow
    {
        public void Run()
        {
            do
            {
                UserIO.SplashScreen();
                UserIO.WelcomeUser();

                ////Players and Boards

                Player User1 = new Player();
                Player User2 = new Player();
                User1.EnemyPlayer = User2;
                User2.EnemyPlayer = User1;

                UserIO.User1(User1);
                UserIO.DisplayBoard(User1.Board);
                UserIO.PlaceShips(User1.Board);
                UserIO.ClearConsole("Press key and end turn.");

                UserIO.User2(User2);
                UserIO.DisplayBoard(User2.Board);
                UserIO.PlaceShips(User2.Board);
                UserIO.ClearConsole("Press key and end turn");

                UserIO.Randomize(User1, User2);
                UserIO.ClearConsole("Press any key");

                UserIO.TakingTurns(User1, User2);
            }

            while (UserIO.VictoryAndGlory() == true);

        }

    }
}