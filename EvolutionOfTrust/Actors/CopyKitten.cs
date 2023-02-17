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
            return CheatedTwice(history) ? Move.Cheat : Move.Cooperate;
        }

        public bool CheatedTwice(History history)
        {
            return history.Count < 2 ? false : 
                history.OtherMoves(this).TakeLast(2).All(move => move.Equals(Move.Cheat));
        }

        public override Actor DoClone()
        {
            return new CopyKitten();
        }
    }
}