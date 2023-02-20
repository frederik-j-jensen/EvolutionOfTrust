using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// Population 4 towards investigating Biased actors
    /// 8 AlwaysCheat Blue
    /// 8 AlwaysCooperate Blue
    /// 8 CopyCat Blue
    /// 8 AlwaysCheat Red
    /// 8 AlwaysCooperate red
    /// 8 Biased Red
    /// </summary>
    public class PopulationFJ4 : PopulationBuilder
    {

        public PopulationFJ4() : base(48) { }

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
            else if (i < 24)
            {
                actor = new CopyCat();
            }
            else if (i < 32)
            {
                actor = new AlwaysCheat();
                actor.Colour = Colours.Red;
            }
            else if (i < 40)
            {
                actor = new AlwaysCooperate();
                actor.Colour = Colours.Red;
            }
            else
            {
                actor = new Biased();
            }
            return actor;
        }
    }
}
