using EvolutionOfTrust;
using EvolutionOfTrust.Model;

Console.WriteLine("***************************************************************");
Console.WriteLine("*          Welcome to Frederik's Evolution of Trust!          *");
Console.WriteLine("* Based on \"The Evolution of Trust\" (https://ncase.me/trust/) *");
Console.WriteLine("***************************************************************");

var parameters = new Parameters();
parameters.ProbabilityOfMistakePercent = 5.0;
parameters.Seed = DateTimeOffset.Now.Millisecond;
var game = new Game(PopulationBuilder.NCasePopulation6(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));
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