using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    public class RandomPopulation : PopulationBuilder
    {
        private readonly Random Random;

        public RandomPopulation(int totalPopulation) : this(totalPopulation, new Random()) { }

        public RandomPopulation(int totalPopulation, Random random) : base(totalPopulation) { 
            Random = random;
        }

        protected override Actor CreateActor()
        {
            switch (Random.Next(10))
            {
                case 0: return new AlwaysCheat();
                case 1: return new AlwaysCooperate();
                case 2: return new Biased();
                case 3: return new CopyCat();
                case 4: return new CopyKitten();
                case 5: return new Grudger();
                case 6: return new Detective();
                case 7: return new Grudger();
                case 8: return new Monkey(Random);
                case 9: return new Simpleton();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
