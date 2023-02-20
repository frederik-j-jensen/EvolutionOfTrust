using EvolutionOfTrust;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.PopulationBuilders;
using System.Text;

var output = new StringBuilder();

output.AppendLine("***************************************************************");
output.AppendLine("*          Welcome to Frederik's Evolution of Trust!          *");
output.AppendLine("* Based on \"The Evolution of Trust\" (https://ncase.me/trust/) *");
output.AppendLine("***************************************************************");


output.AppendLine("---------------------------------------------------------------");
output.AppendLine(" SCENARIO 1:");
output.AppendLine("---------------------------------------------------------------");
{
    var parameters = new Parameters();
    parameters.ProbabilityOfMistakePercent = 0.0;
    parameters.Seed = DateTimeOffset.Now.Millisecond;
    var game = new Game(new PopulationFJ1(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));

    game.Play(output);
}

output.AppendLine("---------------------------------------------------------------");
output.AppendLine(" SCENARIO 2:");
output.AppendLine("---------------------------------------------------------------");
{
    var parameters = new Parameters();
    parameters.ProbabilityOfMistakePercent = 0.0;
    parameters.NumberOfRounds = 5;
    parameters.Seed = DateTimeOffset.Now.Millisecond;
    var game = new Game(new PopulationFJ2(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));

    game.Play(output);
}


output.AppendLine("---------------------------------------------------------------");
output.AppendLine(" SCENARIO 3:");
output.AppendLine("---------------------------------------------------------------");
{
    var parameters = new Parameters();
    parameters.ProbabilityOfMistakePercent = 0.0;
    parameters.NumberOfRounds = 5;
    parameters.Seed = DateTimeOffset.Now.Millisecond;
    var game = new Game(new PopulationFJ3(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));

    game.Play(output);
}


output.AppendLine("---------------------------------------------------------------");
output.AppendLine(" SCENARIO 4:");
output.AppendLine("---------------------------------------------------------------");
{
    var parameters = new Parameters();
    parameters.ProbabilityOfMistakePercent = 0.0;
    parameters.NumberOfRounds = 5;
    parameters.Seed = DateTimeOffset.Now.Millisecond;
    var game = new Game(new PopulationFJ4(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));

    game.Play(output);
}

output.AppendLine("---------------------------------------------------------------");
output.AppendLine(" SCENARIO 5:");
output.AppendLine("---------------------------------------------------------------");
{
    var parameters = new Parameters();
    parameters.ProbabilityOfMistakePercent = 0.0;
    parameters.NumberOfRounds = 5;
    parameters.Seed = DateTimeOffset.Now.Millisecond;
    var game = new Game(new PopulationFJ5(), EvolutionModel.NCase(), parameters, new Random(parameters.Seed));

    game.Play(output);
}

var directory = Directory.GetCurrentDirectory();
var filename = "evolutionoftrust.txt";
Console.WriteLine($"EVOLUTION OF TRUST 2.0: Output written to {directory}\\{filename}");

File.WriteAllText(filename, output.ToString());