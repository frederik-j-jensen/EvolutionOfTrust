using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class AlwaysCheat : Actor
    {
        public AlwaysCheat() : base(nameof(AlwaysCheat)) { }

        public override Move ChooseMove(History history)
        {
            return Move.Cheat;
        }

        public override Actor DoClone()
        {
            return new AlwaysCheat();
        }
    }
}
