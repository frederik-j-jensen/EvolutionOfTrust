using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// The population from NCase EvolutionOfTrust step 4:
    /// 5 CopyCat
    /// 5 AlwaysCheat
    /// 15 AlwaysCooperate
    /// </summary>
    public class NCasePopulation4 : PopulationBuilder
    {

        private int Count = 0;

        public NCasePopulation4() : base(25) { }

        protected override Actor CreateActor()
        {
            Actor actor;
            if (Count < 5)
            {
                actor = new AlwaysCheat();
            }
            else if (Count < 10)
            {
                actor = new CopyCat();
            }
            else
            {
                actor = new AlwaysCooperate();
            }
            Count++;
            return actor;
        }
    }
}
