using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.EvolutionModels
{
    /// <summary>
    /// An evolution model that replicate an s-curve.
    /// </summary>
    public class SCurve : EvolutionModel
    {
        private const int TargetPopulation = 50;
        private const double GrowthFactor = 20;
        private const double DeclineFactor = 0.2;

        public override IEnumerable<Actor> Winners(RankedActors population)
        {
            // TODO: What happens when population count > TargetPopulation?
            var expandCount = (int)(GrowthFactor * (1 - population.Count * 1.0 / TargetPopulation));
            return population.Top(expandCount);
        }

        public override IEnumerable<Actor> Loosers(RankedActors population)
        {
            var eliminateCount = (int)(DeclineFactor * population.Count);
            return population.Bottom(eliminateCount);
        }
    }
}
