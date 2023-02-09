using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class Monkey : Actor
    {
        private static Random Random = new Random();

        public Monkey() : base(nameof(Monkey)) { }

        public override Move ChooseMove(History history)
        {
            return Random.Next(2) == 0 ? Move.Cheat: Move.Cooperate;
        }

        public override Actor Clone()
        {
            return new Monkey();
        }
    }
}