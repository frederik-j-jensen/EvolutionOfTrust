using EvolutionOfTrust;
using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.PopulationBuilders;
using System.Threading.Channels;

namespace Test
{
    [TestClass]
    public class FJGameTest
    {

        [TestMethod]
        public void PopulationFJ1()
        {
            int seed = 123123123;

            var populationBuilder = new PopulationFJ1();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfTurns = 40;
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
        public void PopulationFJ2()
        {
            int seed = 123123123;

            var populationBuilder = new PopulationFJ2();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfTurns = 40;
            parameters.NumberOfRounds = 5;
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
        public void PopulationFJ3()
        {
            int seed = 123123123;

            var populationBuilder = new PopulationFJ3();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfTurns = 40;
            parameters.NumberOfRounds = 5;
            var random = new Random(seed);

            var expectedWinners = new Actor[] {
                new Biased(),
                new Biased(),
                new Biased(),
                new Biased(),
                new Biased(),
            };

            var game = new Game(populationBuilder, evolutionModel, parameters, random);
            game.RunToEnd();
            CompareWinners(expectedWinners, game.Winners());
        }

        [TestMethod]
        public void PopulationFJ4()
        {
            int seed = 123123123;

            var populationBuilder = new PopulationFJ4();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            parameters.NumberOfTurns = 40;
            parameters.NumberOfRounds = 5;
            var random = new Random(seed);

            var game = new Game(populationBuilder, evolutionModel, parameters, random);
            game.RunToEnd();

            var winners = game.Winners();
            foreach (var actual in winners)
            {
                Assert.AreEqual(nameof(AlwaysCheat), actual.Name); // Some may be Blue
            }
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
