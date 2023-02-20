using System.Collections;

namespace EvolutionOfTrust.Model
{
    public class History : IEnumerable<Tuple<Move, Move>>
    {
        private List<Tuple<Move, Move>> Moves = new List<Tuple<Move, Move>>();

        private Actor Actor1, Actor2;

        public int Count { get { return Moves.Count; } }

        public History(Actor actor1, Actor actor2)
        {
            Actor1 = actor1;
            Actor2 = actor2;
        }

        public Colours OtherColour(Actor me) { return Actor1.Equals(me) ? Actor2.Colour : Actor1.Colour; }

        public IEnumerable<Move> OtherMoves(Actor me) { return Moves.Select(tupple => Actor1.Equals(me) ? tupple.Item2 : tupple.Item1); }
        public Move OtherPreviousMove(Actor me)
        {
            var tupple = Moves.Last();
            return Actor1.Equals(me) ? tupple.Item2 : tupple.Item1;
        }

        public Move MyPreviousMove(Actor me)
        {
            var tupple = Moves.Last();
            return Actor1.Equals(me) ? tupple.Item1 : tupple.Item2;
        }

        public void AddMove(Move move1, Move move2) { Moves.Add(new Tuple<Move, Move>(move1, move2)); }

        public bool IsEmpty() { return 0 == Moves.Count; }

        public IEnumerator<Tuple<Move, Move>> GetEnumerator()
        {
            return Moves.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Moves.GetEnumerator();
        }
    }
}
