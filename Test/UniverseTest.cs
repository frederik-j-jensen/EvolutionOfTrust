using EvolutionOfTrust.Model;

namespace Test
{
    [TestClass]
    public class UniverseTest
    {
        [TestMethod]
        public void NCasePopulation4()
        {
            var populationBuilder = PopulationBuilder.NCasePopulation4();
            CreateAndTestUniverse(populationBuilder);
        }

        [TestMethod]
        public void NCasePopulation5()
        {
            var populationBuilder = PopulationBuilder.NCasePopulation5();
            CreateAndTestUniverse(populationBuilder);
        }

        [TestMethod]
        public void NCasePopulation6()
        {
            var populationBuilder = PopulationBuilder.NCasePopulation6();
            CreateAndTestUniverse(populationBuilder);
        }

        private void CreateAndTestUniverse(PopulationBuilder populationBuilder)
        {
            var universe = new Universe(populationBuilder);

            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            Assert.AreEqual(0, universe.Turn);
            foreach (var actor in universe.Population)
            {
                Assert.AreEqual(0, actor.Score);
                Assert.AreEqual(Rankings.None, actor.Ranking);
            }

            universe.Turn++;
            Assert.AreEqual(1, universe.Turn);

            Assert.AreEqual(0, universe.Winners().Count());
            Assert.AreEqual(0, universe.Loosers().Count());

            universe.EliminateLoosers();
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
            universe.ReproduceWinners();
            Assert.AreEqual(populationBuilder.TotalPopulation, universe.PopulationCount);
        }
    }
}
