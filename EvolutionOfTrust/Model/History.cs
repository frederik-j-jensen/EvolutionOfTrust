using System.Collections;

namespace EvolutionOfTrust.Model
{
    public class History : IEnumerable<Move>
    {
        private Stack<Move> Moves = new Stack<Move>();

        public int Count { get { return Moves.Count; } }

        public Move LastMove() { return Moves.Last(); }

        public void AddMove(Move move) { Moves.Push(move); }

        public bool IsEmpty() { return 0 == Moves.Count; }

        public IEnumerator<Move> GetEnumerator()
        {
            return Moves.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Moves.GetEnumerator();
        }
    }
}
