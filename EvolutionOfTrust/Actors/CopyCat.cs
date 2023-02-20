using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class CopyCat : Actor
    {
        public CopyCat() : this(Colours.Blue) { }
        public CopyCat(Colours colour) : base(nameof(CopyCat), colour) { }

        public override Move ChooseMove(History history)
        {
            return history.IsEmpty() ? Move.Cooperate : history.OtherPreviousMove(this);
        }

        public override Actor DoClone()
        {
            return new CopyCat();
        }
    }
}