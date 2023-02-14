using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    /// <summary>
    /// Hello! I'm like Copycat, except I Cheat back only after you Cheat me twice in a row. 
    /// After all, the first one could be a mistake! Purrrrr
    /// </summary>
    public class CopyKitten : Actor
    {
        public CopyKitten() : base(nameof(CopyKitten)) { }

        public override Move ChooseMove(History history)
        {
            return history.Count < 2 ? Move.Cooperate :
                CheatedTwice(history) ? Move.Cheat : Move.Cooperate;
        }

        private bool CheatedTwice(History history)
        {
            return history.OtherMoves(this).TakeLast(2).All(move => move.Equals(Move.Cheat));
        }

        public override Actor Clone()
        {
            return new CopyKitten();
        }
    }
}