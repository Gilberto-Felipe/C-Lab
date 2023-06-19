using BattleShipLibrary.Models;
using static BattleShipLibrary.Models.Enums;

namespace BattleShipLibrary
{
    public class GameLogic
    {
        public static int GetShotCount(PlayerInfoModel player)
        {
            int shotCount = 0;

            foreach (var shot in player.ShotGrid)
            {
                if (shot.Status != GridSpotStatus.Empty)
                {
                    shotCount++;
                }
            }

            return shotCount;
        }

        public static bool IndentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            bool isAHit = false;

            foreach (var ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isAHit = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }

            return isAHit;
        }

        public static void InitializeGrid(PlayerInfoModel model)
        {
            var letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };

            var numbers = new List<int>
            {
                1, 
                2, 
                3, 
                4, 
                5
            };

            foreach (var letter in letters)
            {
                foreach (var number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }

        public static void MarkShortResult(PlayerInfoModel player, string row, int column, bool isAHit)
        {
            foreach(var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (isAHit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            bool output = false;

            (string row, int column) = SplitShotIntoRowAndColumn(location);

            bool isValidLocation = ValidateGridLocation(model, row, column);

            bool isSpotEmpty = ValidateShipLocation(model, row, column);

            if (isValidLocation && isSpotEmpty)
            {
                model.ShipLocations.Add(new GridSpotModel
                {
                    SpotLetter = row.ToUpper(),
                    SpotNumber = column,
                    Status = GridSpotStatus.Ship
                });

                output = true;
            }

            return output;
        }

        private static bool ValidateShipLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValidLocation = true;

            foreach (var ship in model.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = false;
                }
            }

            return isValidLocation;
        }

        private static bool ValidateGridLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValidLocation = false;

            foreach (var ship in model.ShotGrid)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = true;
                }
            }

            return isValidLocation;
        }

        public static bool PlayerStillActive(PlayerInfoModel player)
        {
            bool isActive = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    isActive = true;
                    break;
                }
            }

            return isActive;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string location)
        {
            if (location.Length != 2)
            {
                throw new ArgumentException("Invalid location", nameof(location));
            }

            char[] shotArray = location.ToArray();

            string row = shotArray[0].ToString();
            int column = int.Parse(shotArray[1].ToString());
            return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel player, string row, int column)
        {
            bool isValidShot = false;

            foreach (var gridSpot in player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (gridSpot.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }

            return isValidShot;
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            var spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }
        public static int RollDice()
        {
            var random = new Random();
            int output = random.Next(1, 7);
            return output;
        }

        public static (PlayerInfoModel, PlayerInfoModel) SwapTurns(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            // Swap variables with a Tuple
            (activePlayer, opponent) = (opponent, activePlayer);
            return (activePlayer, opponent);
        }
    }
}
