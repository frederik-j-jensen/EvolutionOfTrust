using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace Test
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void AlwaysCheat()
        {
            var other = new AlwaysCooperate();
            var me = new AlwaysCheat();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void AlwaysCooperate()
        {
            var other = new AlwaysCooperate();
            var me = new AlwaysCooperate();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
        }

        [TestMethod]
        public void BiasedAgainstBlue()
        {
            var other = new AlwaysCooperate();
            var me = new Biased();
            Assert.AreEqual(Colours.Red, me.Colour);
            Assert.AreNotEqual(me.Colour, other.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void BiasedAgainstRed()
        {
            var other = new AlwaysCooperate();
            other.Colour = Colours.Red;
            var me = new Biased();
            Assert.AreEqual(Colours.Red, me.Colour);
            Assert.AreEqual(me.Colour, other.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
        }

        [TestMethod]
        public void CopyCat()
        {
            var other = new AlwaysCooperate();
            var me = new CopyCat();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void CopyKitten()
        {
            var other = new AlwaysCooperate();
            var me = new CopyKitten();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory3(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void CopyKittenCheatedTwice()
        {
            var other = new AlwaysCooperate();
            var me = new CopyKitten();
            {
                var h = EmptyHistory(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsFalse(b);
            }
            {
                var h = HistoryOfCheating(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsTrue(b);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsFalse(b);
            }
            {
                var h = MixedHistory1(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsFalse(b);
            }
            {
                var h = MixedHistory2(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsFalse(b);
            }
            {
                var h = MixedHistory3(me, other);
                var b = me.CheatedTwice(h);
                Assert.IsTrue(b);
            }
        }

        [TestMethod]
        public void Detective()
        {
            var other = new AlwaysCooperate();
            var me = new Detective();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
        }

        [TestMethod]
        public void Grudger()
        {
            var other = new AlwaysCooperate();
            var me = new Grudger();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void Monkey()
        {
            var other = new AlwaysCooperate();
            const int seed = 123123123; // This seed produces the sequence { 1, 0, 0, 1, 0} as the next 5 numbers
            var random = new Random(seed);

            var me = new Monkey(random);
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cheat, m);
            }
        }

        [TestMethod]
        public void Simpleton()
        {
            var other = new AlwaysCooperate();
            var me = new Simpleton();
            Assert.AreEqual(Colours.Blue, me.Colour);
            Assert.AreEqual(Rankings.None, me.Ranking);
            {
                var h = EmptyHistory(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCheating(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = HistoryOfCooperation(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory1(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
            {
                var h = MixedHistory2(me, other);
                var m = me.ChooseMove(h);
                Assert.AreEqual(Move.Cooperate, m);
            }
        }

        private History EmptyHistory(Actor a1, Actor a2) { return new History(a1, a2); }

        private History HistoryOfCooperation(Actor a1, Actor a2)
        {
            var h = new History(a1, a2);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            return h;
        }

        private History HistoryOfCheating(Actor a1, Actor a2)
        {
            var h = new History(a1, a2);
            h.AddMove(Move.Cheat, Move.Cheat);
            h.AddMove(Move.Cheat, Move.Cheat);
            return h;
        }

        private History MixedHistory1(Actor a1, Actor a2)
        {
            var h = new History(a1, a2);
            h.AddMove(Move.Cheat, Move.Cheat);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            return h;
        }

        private History MixedHistory2(Actor a1, Actor a2)
        {
            var h = new History(a1, a2);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cheat, Move.Cheat);
            return h;
        }

        private History MixedHistory3(Actor a1, Actor a2)
        {
            var h = new History(a1, a2);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cooperate, Move.Cooperate);
            h.AddMove(Move.Cheat, Move.Cheat);
            h.AddMove(Move.Cheat, Move.Cheat);
            return h;
        }
    }
}