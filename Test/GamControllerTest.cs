using EvolutionOfTrust.Controller;
using EvolutionOfTrust.EvolutionModels;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.PopulationBuilders;

namespace Test
{
    [TestClass]
    public class GamControllerTest
    {
        [TestMethod]
        public void PlayAndResolveTournament()
        {
            var populationBuilder = new NCasePopulation4();
            var universe = new Universe(populationBuilder);
            var evolutionModel = new NCase();
            var parameters = new Parameters();
            var random = new Random();

            var controller = new GameController(universe, evolutionModel, parameters, random);

            Assert.AreEqual(0, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
                Assert.AreEqual(Rankings.None, actor.Ranking);
            }

            controller.PlayTournament();

            Assert.AreEqual(0, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            foreach (var actor in universe.Population)
            {
                Assert.AreNotEqual(0, actor.Score);
            }
            Assert.AreEqual(5, universe.Winners().Count());
            Assert.AreEqual(5, universe.Loosers().Count());

            controller.ResolveTournament();

            Assert.AreEqual(1, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
                Assert.AreEqual(Rankings.None, actor.Ranking);
            }
            Assert.AreEqual(0, universe.Winners().Count());
            Assert.AreEqual(0, universe.Loosers().Count());

            controller.PlayTournament();

            Assert.AreEqual(1, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            foreach (var actor in universe.Population)
            {
                Assert.AreNotEqual(0, actor.Score);
            }
            Assert.AreEqual(5, universe.Winners().Count());
            Assert.AreEqual(5, universe.Loosers().Count());
        }

        [TestMethod]
        public void PlayTurn()
        {
            var populationBuilder = new NCasePopulation4();
            var universe = new Universe(populationBuilder);
            var evolutionModel = new NCase();
            var parameters = new Parameters();
            var random = new Random();

            var controller = new GameController(universe, evolutionModel, parameters, random);

            Assert.AreEqual(0, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
                Assert.AreEqual(Rankings.None, actor.Ranking);
            }

            {
                var result = controller.PlayTurn();
                Assert.IsTrue(result);
                Assert.AreEqual(1, universe.Turn);
                Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            }

            {
                var result = controller.PlayTurn();
                Assert.IsTrue(result);
                Assert.AreEqual(2, universe.Turn);
                Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            }

        }

        [TestMethod]
        public void PlayToEnd()
        {
            var populationBuilder = new NCasePopulation4();
            var universe = new Universe(populationBuilder);
            var evolutionModel = new NCase();
            var parameters = new Parameters();
            var random = new Random();

            var controller = new GameController(universe, evolutionModel, parameters, random);

            Assert.AreEqual(0, universe.Turn);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
                Assert.AreEqual(Rankings.None, actor.Ranking);
            }

            controller.PlayToEnd();

            Assert.AreEqual(parameters.NumberOfTurns, universe.Turn);
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
        }

    }
}
