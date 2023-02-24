using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;
using System.Drawing;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// Population 5 towards investigating Biased actors
    /// Blue population:
    /// 4 AlwaysCheat Blue
    /// 4 AlwaysCooperate Blue
    /// 4 CopyCat Blue
    /// Green population:
    /// 4 AlwaysCheat Green
    /// 4 AlwaysCooperate Green
    /// 4 CopyCat Green
    /// Yellow population:
    /// 4 AlwaysCheat Yellow
    /// 4 AlwaysCooperate Yellow
    /// 4 CopyCat Yellow?
    /// Red population:
    /// 4 AlwaysCheat Red
    /// 4 AlwaysCooperate Red
    /// 4 Biased Red
    /// </summary>
    public class PopulationFJ5 : PopulationBuilder
    {

        public PopulationFJ5() : base(48) { }

        protected override Actor CreateActor(int i)
        {
            if (i < 12)
            {
                return CreateActor(i, Colours.Blue);
            }
            else if (i < 24)
            {
                return CreateActor(i, Colours.Yellow);
            }
            else if (i < 36)
            {
                return CreateActor(i, Colours.Green);
            }
            else if (i < 44)
            {
                return CreateActor(i, Colours.Red);
            }
            else
            {
                return new Biased(Colours.Red);
            }
        }

        private Actor CreateActor(int i, Colours colour)
        {
            switch (i % 12)
            {
                case < 4:
                    {
                        return new AlwaysCheat(colour);
                    }
                case < 8:
                    {
                        return new AlwaysCooperate(colour);
                    }
                default:
                    {
                        return new CopyCat(colour);
                    }
            }

        }
    }
}
