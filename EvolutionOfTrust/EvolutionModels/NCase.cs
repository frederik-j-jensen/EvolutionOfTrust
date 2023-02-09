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

        public override IEnumerable<Actor> Winners(Universe universe)
        {
            // TODO: Clone the 5 best players. (if there's a tie, pick randomly between them)
            return universe.Population.Top(ExpandCount);
        }

        public override IEnumerable<Actor> Loosers(Universe universe)
        {
            // TODO: Get rid of the 5 worst players. (if there's a tie, pick randomly between them)
            return universe.Population.Bottom(EliminateCount);
        }
    }
}
