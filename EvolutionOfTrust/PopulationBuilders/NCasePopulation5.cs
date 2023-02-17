﻿using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.PopulationBuilders
{
    /// <summary>
    /// The population from NCase EvolutionOfTrust step 5.
    /// 1 CopyCat
    /// 1 AlwaysCheat
    /// 23 AlwaysCooperate
    /// </summary>
    public class NCasePopulation5 : PopulationBuilder
    {

        private int Count = 0;

        public NCasePopulation5() : base(25) { }

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
