using System;
using BattleShip.BLL.GameLogic;

namespace BattleShip.UI
{
    public class Player
    {
        public Player EnemyPlayer { get; set; }
        public string Name { get; set; }
        public Board Board { get; set; }
       
       public Player()
        {
            Board = new Board();
        }
    }
}

 //*
 //* Display Shot - does not end after one valid shot
 //* 