using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// The population from NCase EvolutionOfTrust step 6.
    /// </summary>
    public class NCasePopulation6 : PopulationBuilder
    {

        private int Count = 0;
        private readonly Random Random;

        public NCasePopulation6() : this(new Random()) { }

        public NCasePopulation6(Random random) : base(25)
        {
            Random = random;
        }

        protected override Actor CreateActor()
        {
            Actor actor;
            if (Count <= 12)
            {
                actor = new AlwaysCheat();
            }
            else if (Count <= 15)
            {
                actor = new CopyCat();
            }
            else if (Count <= 18)
            {
                actor = new CopyKitten();
            }
            else if (Count <= 21)
            {
                actor = new Simpleton();
            }
            else
            {
                actor = new Monkey(Random);
            }
            Count++;
            return actor;
        }
    }
}
