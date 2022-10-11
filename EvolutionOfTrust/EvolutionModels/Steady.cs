using GameOfTrust.Model;

namespace GameOfTrust.EvolutionModels
{
    public class Steady : EvolutionModel
    {
        private const int EliminateCount = Parameters.InitialPopulationSize/5;
        private const int ExpandCount = Parameters.InitialPopulationSize/5;

        public Steady() { }

        public override IEnumerable<Actor> Winners(Universe universe)
        {
            return universe.Population.Top(ExpandCount);
        }

        public override IEnumerable<Actor> Loosers(Universe universe)
        {
            return universe.Population.Bottom(EliminateCount);
        }
    }
}
