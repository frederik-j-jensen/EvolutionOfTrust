using GameOfTrust.Actors;
using GameOfTrust.Model;

namespace GameOfTrust.PopulationBuilders
{
    public class Step6Distribution : PopulationBuilder
    {

        private int Count = 0;

        public Step6Distribution(int totalPopulation) : base(totalPopulation) { }

        protected override Actor CreateActor()
        {
            Actor actor;
            if (Count == 0)
            {
                actor = new AlwaysCheat();
            }
            else if (Count == 1)
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
