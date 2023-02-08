using GameOfTrust.Model;

namespace GameOfTrust.EvolutionModels
{
    /// <summary>
    /// An evolution model that replicate an s-curve.
    /// </summary>
    public class SCurve : EvolutionModel
    {
        private const int TargetPopulation = 50;
        private const double GrowthFactor = 20;
        private const double DeclineFactor = 0.2;

        public override IEnumerable<Actor> Winners(Universe universe)
        {
            // TODO: What happens when population count > TargetPopulation?
            var expandCount = (int)(GrowthFactor * (1 - universe.Population.Count * 1.0 / TargetPopulation));
            return universe.Population.Top(expandCount);
        }

        public override IEnumerable<Actor> Loosers(Universe universe)
        {
            var eliminateCount = (int)(DeclineFactor * universe.Population.Count);
            return universe.Population.Bottom(eliminateCount);
        }
    }
}
