// See https://aka.ms/new-console-template for more information
using BattleShipLibrary;
using BattleShipLibrary.Models;
using BattleShipLiteUI;


DisplayUI.WelcomeMessage();

var activePlayer = DisplayUI.CreatePlayer("Player 1");
var opponent = DisplayUI.CreatePlayer("Player 2");
PlayerInfoModel winner = null;

do
{
    DisplayUI.DisplayShotGrid(activePlayer);

    DisplayUI.RecordPlayerShot(activePlayer, opponent);

    bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

    if (doesGameContinue)
    {
        // Swaps player positions using a Tupple
        (activePlayer, opponent) = (opponent, activePlayer);

        Console.Clear();
    } 
    else
    {
        winner = activePlayer;
    }
} while (winner == null);

DisplayUI.IdentifyWinner(winner);

