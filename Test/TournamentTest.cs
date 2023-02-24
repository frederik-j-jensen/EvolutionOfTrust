using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;

namespace Test
{
    [TestClass]
    public class TournamentTest
    {
        [TestMethod]
        public void TestSingleActor()
        {
            int seed = 123123123;
            var parameters = new Parameters();
            var random = new Random(seed);
            var tournament = new Tournament(parameters, random);

            var actors = new List<Actor>();

            actors.Add(new TestActor(Move.Cheat));

            tournament.Play(actors);

            TestActor actor = (TestActor)actors.First();

            Assert.AreEqual(0, actor.MoveCount);
        }

        [TestMethod]
        public void TestTwoActors()
        {
            int seed = 123123123;
            var parameters = new Parameters();
            var random = new Random(seed);
            var tournament = new Tournament(parameters, random);

            var actors = new List<Actor>();

            actors.Add(new TestActor(Move.Cheat));
            actors.Add(new TestActor(Move.Cooperate));

            tournament.Play(actors);

            TestActor actor = (TestActor)actors.First();

            Assert.AreEqual(parameters.NumberOfRounds, actor.MoveCount);
        }

        [TestMethod]
        public void TestFourActors()
        {
            int seed = 123123123;
            var parameters = new Parameters();
            parameters.NumberOfRounds = 2;
            var random = new Random(seed);
            var tournament = new Tournament(parameters, random);

            var actors = new List<Actor>();

            actors.Add(new TestActor(Move.Cheat));
            actors.Add(new TestActor(Move.Cooperate));
            actors.Add(new TestActor(Move.Cheat));
            actors.Add(new TestActor(Move.Cooperate));

            tournament.Play(actors);

            TestActor actor = (TestActor)actors.First();

            Assert.AreEqual(3 * parameters.NumberOfRounds, actor.MoveCount);
        }

    }
}
