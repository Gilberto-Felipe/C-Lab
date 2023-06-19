using BattleShipLiteUI;

DisplayUI.WelcomeMessage();

var activePlayer = DisplayUI.CreatePlayer("Player 1");

var opponent = DisplayUI.CreatePlayer("Player 2");

(activePlayer, opponent) = DisplayUI.SortTurns(activePlayer, opponent);

var winner = DisplayUI.PlayGame(activePlayer, opponent);

DisplayUI.IdentifyWinner(winner);

Console.ReadLine();




