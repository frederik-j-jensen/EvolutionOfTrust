using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class AlwaysCooperate : Actor
    {
        public AlwaysCooperate() : base(nameof(AlwaysCooperate)) { }

        public override Move ChooseMove(History history)
        {
            return Move.Cooperate;
        }
        public override Actor Clone()
        {
            return new AlwaysCooperate();
        }

    }
}
