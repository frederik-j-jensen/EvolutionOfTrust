using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// Population 3 towards investigating Biased actors
    /// 16 AlwaysCheat
    /// 16 AlwaysCooperate
    /// 8 CopyCat
    /// 8 Biased Red
    /// </summary>
    public class PopulationFJ3 : PopulationBuilder
    {

        public PopulationFJ3() : base(48) { }

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
            else if (i < 40)
            {
                actor = new CopyCat();
            }
            else
            {
                actor = new Biased();
            }
            return actor;
        }
    }
}
