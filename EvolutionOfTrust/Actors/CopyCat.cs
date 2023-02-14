using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class CopyCat : Actor
    {
        public CopyCat() : base(nameof(CopyCat)) { }

        public override Move ChooseMove(History history)
        {
            return history.IsEmpty() ? Move.Cooperate : history.OtherPreviousMove(this);
        }

        public override Actor Clone()
        {
            return new CopyCat();
        }
    }
}