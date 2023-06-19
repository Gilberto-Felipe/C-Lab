using BattleShipLibrary.Models;
using BattleShipLibrary;
using static BattleShipLibrary.Models.Enums;

namespace BattleShipLiteUI
{
    public static class DisplayUI
    {
        public static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.Clear();
            Console.WriteLine($"{winner.UserName} win!");
            Console.WriteLine($"{winner.UserName} took {GameLogic.GetShotCount(winner)} shots.");
        }

        public static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);

                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);

                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception)
                {
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please, try again.");
                }
            } while (isValidShot == false);

            bool isAHit = GameLogic.IndentifyShotResult(opponent, row, column);

            GameLogic.MarkShortResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);

            Console.ReadLine();
        }

        public static void DisplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{row}{column} is a Hit!"); 
            }
            else
            {
                Console.WriteLine($"{row}{column} is a Miss!");
            }
        }

        public static string AskForShot(PlayerInfoModel player)
        {
            Console.WriteLine("\n");
            Console.Write($"{ player.UserName.ToUpper() }, enter your shot: ");
            var output = Console.ReadLine();

            return output;
        }

        public static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            var currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($"{gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O ");
                }
                else
                {
                    Console.Write(" ?  ");
                }
            }
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite\n");
            Console.WriteLine("Created by Gilberto Ramirez\n");
            Console.WriteLine("****************************\n");
        }

        public static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            var output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            output.UserName = AskForPlayersName();

            GameLogic.InitializeGrid(output);

            PlaceShips(output);

            Console.Clear();

            return output;
        }

        public static string AskForPlayersName()
        {
            Console.Write("What is your name? ");
            var output = Console.ReadLine();
            return output;
        }

        public static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                var location = Console.ReadLine();

                bool isValidLocation = false;

                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception)
                {
                    // catch in the isValidLocation == false
                }

                if (isValidLocation == false)
                {
                    Console.WriteLine("It's not a valid location. Please, try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }

        public static PlayerInfoModel PlayGame(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            PlayerInfoModel winner = null;

            do
            {
                DisplayUI.DisplayShotGrid(activePlayer);

                DisplayUI.RecordPlayerShot(activePlayer, opponent);

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                if (doesGameContinue)
                {
                    (activePlayer, opponent) = GameLogic.SwapTurns(activePlayer, opponent);

                    Console.Clear();
                }
                else
                {
                    winner = activePlayer;
                }
            } while (winner == null);

            return winner;
        }

        public static (PlayerInfoModel, PlayerInfoModel) SortTurns(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            Console.WriteLine("Rolling the Dices to get the turns.\n");

            int firstDice;
            int secondDice;
            bool isADraw = false;

            do
            {
                firstDice = GameLogic.RollDice();
                Console.WriteLine($"{activePlayer.UserName.ToUpper()} dice result: {firstDice}.\n");

                secondDice = GameLogic.RollDice();
                Console.WriteLine($"{opponent.UserName.ToUpper()} dice result: {secondDice}.\n");

                if (firstDice < secondDice)
                {
                    (activePlayer, opponent) = GameLogic.SwapTurns(activePlayer, opponent);
                }
                else if (firstDice == secondDice)
                {
                    Console.WriteLine("It was a draw. Rolling the dices again.\n");
                    isADraw = true;
                }
            } while (isADraw);

            return (activePlayer, opponent);
        }
    }
}
