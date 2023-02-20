using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// Population 1 towards investigating Biased actors
    /// 8 AlwaysCheat
    /// 8 AlwaysCooperate
    /// 8 CopyCat
    /// </summary>
    public class PopulationFJ1 : PopulationBuilder
    {

        public PopulationFJ1() : base(24) { }

        protected override Actor CreateActor(int i)
        {
            Actor actor;
            if (i < 8)
            {
                actor = new AlwaysCheat();
            }
            else if (i < 16)
            {
                actor = new AlwaysCooperate();
            }
            else
            {
                actor = new CopyCat();
            }
            return actor;
        }
    }
}
