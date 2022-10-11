using GameOfTrust.Model;

namespace GameOfTrust.Actors
{
    public class AlwaysCheat : Actor
    {
        public AlwaysCheat() : base(nameof(AlwaysCheat)) { }

        public override Move ChooseMove(History history)
        {
            return Move.Cheat;
        }

        public override Actor Clone()
        {
            return new AlwaysCheat();
        }
    }
}
