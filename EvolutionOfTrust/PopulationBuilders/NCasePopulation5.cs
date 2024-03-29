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

        public NCasePopulation5() : base(25) { }

        protected override Actor CreateActor(int i)
        {
            Actor actor;
            if (i == 0)
            {
                actor = new AlwaysCheat();
            }
            else if (i == 1)
            {
                actor = new CopyCat();
            }
            else
            {
                actor = new AlwaysCooperate();
            }
            return actor;
        }
    }
}
