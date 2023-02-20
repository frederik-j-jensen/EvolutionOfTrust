using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    public class MultiEthnic : PopulationBuilder
    {

        public MultiEthnic(int totalPopulation) : base(totalPopulation) { }

        protected override Actor CreateActor(int i)
        {
            Actor actor;

            switch (i % 4)
            {
                case 0: { actor = new Biased(Colours.Blue); break; }
                case 1: { actor = new Biased(Colours.Red); break; }
                case 2: { actor = new Biased(Colours.Green); break; }
                default:
                    {
                        actor = new AlwaysCooperate(); break;
                    }
            }
            return actor;
        }
    }
}
