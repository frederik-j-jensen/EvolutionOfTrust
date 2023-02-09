using EvolutionOfTrust;

Console.WriteLine("***************************************************************");
Console.WriteLine("*          Welcome to Frederik's Evolution of Trust!          *");
Console.WriteLine("* Based on \"The Evolution of Trust\" (https://ncase.me/trust/) *");
Console.WriteLine("***************************************************************");

var game = new Game();
Console.WriteLine(game.ViewParameters());
Console.WriteLine(game.ViewSummary());

game.PlayTurn();
Console.WriteLine(game.ViewDetails());
game.ResolveTurn();
Console.WriteLine(game.ViewSummary());

game.PlayTurn();
game.ResolveTurn();
Console.WriteLine(game.ViewSummary());

game.PlayTurn();
game.ResolveTurn();
Console.WriteLine(game.ViewSummary());

game.RunToEnd();
Console.WriteLine(game.ViewSummary());
