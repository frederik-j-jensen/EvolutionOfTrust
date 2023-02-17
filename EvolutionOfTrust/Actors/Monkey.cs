using EvolutionOfTrust.Model;
using System;

namespace EvolutionOfTrust.Actors
{
    /// <summary>
    /// Monkey robot! Ninja pizza tacos! lol i'm so random
    /// (Just plays Cheat or Cooperate randomly with a 50/50 chance)
    /// </summary>
    public class Monkey : Actor
    {
        private Random Random;

        public Monkey(Random random) : base(nameof(Monkey)) {
            Random = random;
        }

        public override Move ChooseMove(History history)
        {
            return Random.Next(2) == 0 ? Move.Cheat : Move.Cooperate;
        }

        public override Actor DoClone()
        {
            return new Monkey(Random);
        }
    }
}