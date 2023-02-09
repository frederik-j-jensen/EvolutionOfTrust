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

        public NCasePopulation6(int totalPopulation) : base(totalPopulation) { }

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
                actor = new Monkey();
            }
            Count++;
            return actor;
        }
    }
}
