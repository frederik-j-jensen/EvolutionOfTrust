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
    }
}
