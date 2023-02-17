using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace Test
{
    [TestClass]
    public class HistoryTest
    {

        [TestMethod]
        public void Test1()
        {
            var actor1 = new AlwaysCheat();
            var actor2 = new AlwaysCooperate();
            var h = new History(actor1, actor2);

            Assert.AreEqual(0, h.Count);
            Assert.AreEqual(Colours.Blue, h.OtherColour(actor1));

            h.AddMove(Move.Cheat, Move.Cooperate);

            Assert.AreEqual(1, h.Count);

            Assert.AreEqual(Move.Cheat, h.MyPreviousMove(actor1));
            Assert.AreEqual(Move.Cooperate, h.OtherPreviousMove(actor1));

        }
    }
}
