using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UniverseTest
    {
        [TestMethod]
        public void NCasePopulation4()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation4();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            var random = new Random(seed);

            CreateAndTestUniverse(populationBuilder, evolutionModel, parameters, random);
        }

        [TestMethod]
        public void NCasePopulation5()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation5();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            var random = new Random(seed);

            CreateAndTestUniverse(populationBuilder, evolutionModel, parameters, random);
        }

        [TestMethod]
        public void NCasePopulation6()
        {
            int seed = 123123123;

            var populationBuilder = PopulationBuilder.NCasePopulation6();
            var evolutionModel = EvolutionModel.NCase();
            var parameters = new Parameters();
            var random = new Random(seed);

            CreateAndTestUniverse(populationBuilder, evolutionModel, parameters, random);
        }

        private void CreateAndTestUniverse(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            CreateAndTestUniverseScores(populationBuilder, evolutionModel, parameters, random);
            CreateAndTestUniverseWinners(populationBuilder, evolutionModel, parameters, random);
            CreateAndTestUniverseLoosers(populationBuilder, evolutionModel, parameters, random);
        }

        private void CreateAndTestUniverseScores(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            var universe = new Universe(populationBuilder, evolutionModel, parameters, random);

            Assert.AreEqual(populationBuilder.TotalPopulation, universe.Population.Count);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
            }

            universe.PlayTournament();

            Assert.AreEqual(populationBuilder.TotalPopulation, universe.Population.Count);
            foreach (var actor in universe.Population)
            {
                Assert.AreNotEqual(0, actor.Score);
            }

            universe.ResetScores();

            Assert.AreEqual(populationBuilder.TotalPopulation, universe.Population.Count);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
            }

        }

        private void CreateAndTestUniverseWinners(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            var universe = new Universe(populationBuilder, evolutionModel, parameters, random);
            universe.PlayTournament();

            int numberOfWinners = universe.Winners().Count();

            universe.ReproduceWinners();

            Assert.AreEqual(populationBuilder.TotalPopulation + numberOfWinners, universe.Population.Count);
        }

        private void CreateAndTestUniverseLoosers(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            var universe = new Universe(populationBuilder, evolutionModel, parameters, random);
            universe.PlayTournament();

            int numberOfLoosers = universe.Loosers().Count();

            universe.EliminateLoosers();

            Assert.AreEqual(populationBuilder.TotalPopulation - numberOfLoosers, universe.Population.Count);

        }

    }
}
