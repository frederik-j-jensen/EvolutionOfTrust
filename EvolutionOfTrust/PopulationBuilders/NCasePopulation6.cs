using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// The population from NCase EvolutionOfTrust step 6.
    /// </summary>
    public class NCasePopulation6 : PopulationBuilder
    {

        private readonly Random Random;

        public NCasePopulation6() : this(new Random()) { }

        public NCasePopulation6(Random random) : base(25)
        {
            Random = random;
        }

        protected override Actor CreateActor(int i)
        {
            Actor actor;
            if (i <= 12)
            {
                actor = new AlwaysCheat();
            }
            else if (i <= 15)
            {
                actor = new CopyCat();
            }
            else if (i <= 18)
            {
                actor = new CopyKitten();
            }
            else if (i <= 21)
            {
                actor = new Simpleton();
            }
            else
            {
                actor = new Monkey(Random);
            }
            return actor;
        }
    }
}
