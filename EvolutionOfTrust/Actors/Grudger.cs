using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    /// <summary>
    /// Listen, pardner. I'll start cooperatin', and keep cooperatin', 
    /// but if y'all ever cheat me, I'LL CHEAT YOU BACK 'TIL THE END OF TARNATION.
    /// </summary>
    public class Grudger : Actor
    {
        public Grudger() : base(nameof(Grudger)) { }

        public override Move ChooseMove(History history)
        {            
            return history.OtherMoves(this).Any(move => move.Equals(Move.Cheat)) ? Move.Cheat : Move.Cooperate;
        }

        public override Actor DoClone()
        {
            return new Grudger();
        }
    }
}