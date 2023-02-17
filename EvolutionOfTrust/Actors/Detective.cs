using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    /// <summary>
    ///  I start: Cooperate, Cheat, Cooperate, Cooperate. 
    ///  If you cheat back, I'll act like Copycat. 
    ///  If you never cheat back, I'll act like Always Cheat, to exploit you. 
    ///  Elementary, my dear Watson.
    /// </summary>
    public class Detective : Actor
    {
        public Detective() : base(nameof(Detective)) { }

        public override Move ChooseMove(History history)
        {
            switch (history.Count)
            {
                case 0: return Move.Cooperate;
                case 1: return Move.Cheat;
                case 2: return Move.Cooperate;
                case 3: return Move.Cooperate;
                default:
                    {
                        return history.OtherMoves(this).Any(move => move.Equals(Move.Cheat)) ? history.OtherPreviousMove(this) : Move.Cheat;
                    }
            }
        }

        public override Actor DoClone()
        {
            return new Detective();
        }
    }
}