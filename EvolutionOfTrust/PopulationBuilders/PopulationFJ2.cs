using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// Population 2 towards investigating Biased actors
    /// 16 AlwaysCheat
    /// 16 AlwaysCooperate
    /// 16 CopyCat
    /// </summary>
    public class PopulationFJ2 : PopulationBuilder
    {

        public PopulationFJ2() : base(48) { }

        protected override Actor CreateActor(int i)
        {
            Actor actor;
            if (i < 16)
            {
                actor = new AlwaysCheat();
            }
            else if (i < 32)
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
