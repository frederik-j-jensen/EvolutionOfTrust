using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.EvolutionModels
{
    /// <summary>
    /// The evolution model from "The Evolution of Trust" (https://ncase.me/trust/)
    /// </summary>
    public class NCase : EvolutionModel
    {
        private const int EliminateCount = 5;
        private const int ExpandCount = 5;

        public NCase() { }

        public override IEnumerable<Actor> Winners(RankedActors population)
        {
            return population.Top(ExpandCount);
        }

        public override IEnumerable<Actor> Loosers(RankedActors population)
        {
            return population.Bottom(EliminateCount);
        }
    }
}
