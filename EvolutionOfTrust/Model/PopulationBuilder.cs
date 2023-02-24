using EvolutionOfTrust.PopulationBuilders;

namespace EvolutionOfTrust.Model
{
    public abstract class PopulationBuilder
    {
        public int TotalPopulation { get; private set; }

        public PopulationBuilder(int totalPopulation)
        {
            TotalPopulation = totalPopulation;
        }

        public IEnumerable<Actor> Create()
        {
            for (int i = 0; i < TotalPopulation; i++)
            {
                yield return CreateActor(i);
            }
        }

        protected abstract Actor CreateActor(int i);

        public static PopulationBuilder NCasePopulation4() { return new NCasePopulation4(); }
        public static PopulationBuilder NCasePopulation5() { return new NCasePopulation5(); }
        public static PopulationBuilder NCasePopulation6() { return new NCasePopulation6(); }

    }
}
