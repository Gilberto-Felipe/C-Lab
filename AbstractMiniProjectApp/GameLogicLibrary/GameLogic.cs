using GameLogicLibrary.Models;
using System;

namespace GameLogicLibrary
{
    public abstract class GameLogic
    {
        public int SortTurns()
        {
            var random = new Random();
            int output = random.Next(1, 3);
            return output;
        }

        public void SetChessBoard()
        {
            var chessBoard = new BoardModel();
            chessBoard.InicializeBoard();
        }

        public abstract int GetPlayerForce(int playerForce);
    }
}
