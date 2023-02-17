using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    /// <summary>
    /// hi i try start cooperate. if you cooperate back, i do same thing as last move, even if it mistake. 
    /// if you cheat back, i do opposite thing as last move, even if it mistake.
    /// </summary>
    public class Simpleton : Actor
    {
        public Simpleton() : base(nameof(Simpleton)) { }

        public override Move ChooseMove(History history)
        {
            var move = DoChooseMove(history);
            return move;
        }

        private Move DoChooseMove(History history) => history.IsEmpty() ? Move.Cooperate
                : history.OtherPreviousMove(this).Equals(Move.Cooperate) ? history.MyPreviousMove(this)
                : history.MyPreviousMove(this).Opposite();

        public override Actor DoClone()
        {
            return new Simpleton();
        }
    }
}
