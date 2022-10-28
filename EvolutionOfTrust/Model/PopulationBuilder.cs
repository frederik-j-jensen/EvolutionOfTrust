using GameOfTrust.PopulationBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTrust.Model
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

        public static PopulationBuilder Step6Distribution(int totalPopulation) { return new Step6Distribution(totalPopulation); }
        public static PopulationBuilder Step6Distribution1(int totalPopulation) { return new Step6Distribution1(totalPopulation); }
        public static PopulationBuilder Step6Distribution2(int totalPopulation) { return new Step6Distribution2(totalPopulation); }
        public static PopulationBuilder RandomPopulation(int totalPopulation) { return new RandomPopulation(totalPopulation); }
        public static PopulationBuilder MultiEthnic(int totalPopulation) { return new MultiEthnic(totalPopulation); }

    }
}
