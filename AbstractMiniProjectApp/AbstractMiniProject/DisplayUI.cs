using GameLogicLibrary.Models;
using GameLogicLibrary;
using System;

namespace AbstractMiniProject
{
    internal class DisplayUI
    {
        internal static void Welcome()
        {
            Console.WriteLine("Hi, Welcome the Chess/Checkers App.");
        }

        internal static (ChessPlayer white, ChessPlayer black) AssignColors(ChessPlayer white, ChessPlayer black, ChessGameLogic game)
        {
            int result = game.SortTurns();

            if (result == 2)
            {
                white.PieceColor = Enums.PieceColor.Black;

                (white, black) = (black, white);

                return (white, black);
            }

            black.PieceColor = Enums.PieceColor.Black;

            return (white, black);
        }

        internal static void PrintColors(ChessPlayer white, ChessPlayer black)
        {
            Console.WriteLine($"White Pieces: {white.Name}");
            Console.WriteLine($"Black Pieces: {black.Name}");
        }

    }
}
