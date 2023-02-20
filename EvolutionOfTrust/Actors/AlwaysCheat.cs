using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class AlwaysCheat : Actor
    {
        public AlwaysCheat() : this(Colours.Blue) { }
        public AlwaysCheat(Colours colour) : base(nameof(AlwaysCheat), colour) { }

        public override Move ChooseMove(History history)
        {
            return Move.Cheat;
        }

        public override Actor DoClone()
        {
            return new AlwaysCheat(Colour);
        }
    }
}
