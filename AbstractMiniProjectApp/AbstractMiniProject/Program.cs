using System;
using GameLogicLibrary;
using GameLogicLibrary.Models;

namespace AbstractMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayUI.Welcome();

            var game = new ChessGameLogic();

            game.SetChessBoard();

            var white = new ChessPlayer
            {
                Name = "Gil"
            };

            var black = new ChessPlayer
            {
                Name = "Machine"
            };

            (white, black) = DisplayUI.AssignColors(white, black, game);

            DisplayUI.PrintColors(white, black);

            Console.ReadLine();
        }
    }
}
