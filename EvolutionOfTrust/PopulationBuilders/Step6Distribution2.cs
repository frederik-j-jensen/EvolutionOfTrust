using GameOfTrust.Actors;
using GameOfTrust.Model;

namespace GameOfTrust.PopulationBuilders
{
    public class Step6Distribution2 : PopulationBuilder
    {

        private int Count = 0;

        public Step6Distribution2(int totalPopulation) : base(totalPopulation) { }

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
