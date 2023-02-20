using EvolutionOfTrust;
using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace Test
{
    [TestClass]
    public class NCaseGameTest
    {

        [TestMethod]
        public void NCase4RepeatedTournamentCopyCatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation4();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
            };

            var game = new Game(populationBuilder, evolutionModel, parameters, random);
            game.RunToEnd();
            CompareWinners(expectedWinners, game.Winners());
        }

        [TestMethod]
        public void NCase51VariableRounds10CopyCatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation5();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase51VariableRounds7CopyCatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation5();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfRounds = 7;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase51VariableRounds5AlwaysCheatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation5();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfRounds = 5;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase52ChangeRewardAlwaysCheatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation5();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.RewardCooporateOtherCooporate = 1;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase6Misteaks0PercentCopyCatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation6();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.ProbabilityOfMistakePercent = 0.0;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
                new CopyCat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase6Misteaks5PercentCopyKittenIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation6();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.ProbabilityOfMistakePercent = 5.0;
            parameters.NumberOfTurns = 50;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new CopyKitten(),
                new CopyKitten(),
                new CopyKitten(),
                new CopyKitten(),
                new CopyKitten(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        [TestMethod]
        public void NCase6Misteaks20PercentAlwaysCheatIsBest()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation6();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.ProbabilityOfMistakePercent = 20.0;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
                new AlwaysCheat(),
            };

            CreateAndTestGame(populationBuilder, evolutionModel, parameters, random, expectedWinners);
        }

        private void CreateAndTestGame(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random, IList<Actor> expectedWinners)
        {
            var game = new Game(populationBuilder, evolutionModel, parameters, random);
            game.RunToEnd();
            CompareWinners(expectedWinners, game.Winners());
        }

        private void CompareWinners(IList<Actor> expectedWinners, IEnumerable<Actor> actualWinners)
        {
            int i = 0;
            foreach (var actual in actualWinners)
            {
                var expected = expectedWinners[i];
                Assert.AreEqual(expected, actual);
                i++;
            }
            Assert.AreEqual(expectedWinners.Count, i);
        }
    }
}
