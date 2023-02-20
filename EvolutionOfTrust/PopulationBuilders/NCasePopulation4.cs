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

        public NCasePopulation4() : base(25) { }

        protected override Actor CreateActor(int i)
        {
            Actor actor;
            if (i < 5)
            {
                actor = new AlwaysCheat();
            }
            else if (i < 10)
            {
                actor = new CopyCat();
            }
            else
            {
                actor = new AlwaysCooperate();
            }
            return actor;
        }
    }
}
