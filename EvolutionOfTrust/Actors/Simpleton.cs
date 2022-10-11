using GameOfTrust.Model;

namespace GameOfTrust.Actors
{
    public class Simpleton : Actor
    {
        private Move _PreviousMove = Move.Cooperate;
        public Simpleton() : base(nameof(Simpleton)) { }

        public override Move ChooseMove(History history)
        {
            var move = DoChooseMove(history);
            _PreviousMove = move;
            return move;
        }

        private Move DoChooseMove(History history) => history.IsEmpty() ? Move.Cooperate
                : history.LastMove().Equals(Move.Cooperate) ? _PreviousMove
                : _PreviousMove.Opposite();

        public override Actor Clone()
        {
            return new Simpleton();
        }
    }
}
