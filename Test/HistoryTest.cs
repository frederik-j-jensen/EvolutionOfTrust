using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace Test
{
    [TestClass]
    public class HistoryTest
    {

        [TestMethod]
        public void AddMove()
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

        [TestMethod]
        public void OtherMoves()
        {
            var actor1 = new AlwaysCheat();
            var actor2 = new AlwaysCooperate();
            var h = new History(actor1, actor2);

            h.AddMove(Move.Cheat, Move.Cooperate);
            h.AddMove(Move.Cheat, Move.Cooperate);

            {
                var moves = h.OtherMoves(actor1).TakeLast(2);
                foreach (var move in moves)
                {
                    Assert.AreEqual(Move.Cooperate, move);
                }
            }

            {
                var moves = h.OtherMoves(actor2).TakeLast(2);
                foreach (var move in moves)
                {
                    Assert.AreEqual(Move.Cheat, move);
                }
            }


        }
    }
}
