using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class AlwaysCooperate : Actor
    {
        public AlwaysCooperate() : this(Colours.Blue) { }
        public AlwaysCooperate(Colours colour) : base(nameof(AlwaysCooperate), colour) { }

        public override Move ChooseMove(History history)
        {
            return Move.Cooperate;
        }
        public override Actor DoClone()
        {
            return new AlwaysCooperate(Colour);
        }

    }
}
