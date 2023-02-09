using EvolutionOfTrust.PopulationBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionOfTrust.Model
{
    public abstract class PopulationBuilder
    {
        public int TotalPopulation;

        public PopulationBuilder(int totalPopulation)
        {
            TotalPopulation = totalPopulation;
        }

        public IEnumerable<Actor> Create()
        {
            for (int i = 0; i < Parameters.InitialPopulationSize; i++)
            {
                yield return CreateActor();
            }
        }

        protected abstract Actor CreateActor();

        public static PopulationBuilder NCasePopulation4(int totalPopulation) { return new NCasePopulation4(totalPopulation); }
        public static PopulationBuilder NCasePopulation5(int totalPopulation) { return new NCasePopulation5(totalPopulation); }
        public static PopulationBuilder NCasePopulation6(int totalPopulation) { return new NCasePopulation6(totalPopulation); }
        public static PopulationBuilder RandomPopulation(int totalPopulation) { return new RandomPopulation(totalPopulation); }
        public static PopulationBuilder MultiEthnic(int totalPopulation) { return new MultiEthnic(totalPopulation); }

    }
}
