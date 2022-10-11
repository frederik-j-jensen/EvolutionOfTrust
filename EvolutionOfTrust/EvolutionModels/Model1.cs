using GameOfTrust.Model;

namespace GameOfTrust.EvolutionModels
{
    public class Model1 : EvolutionModel
    {
        public override IEnumerable<Actor> Loosers(Universe universe)
        {
            return universe.Population.Where(actor => actor.Score <= 0);
        }

        public override IEnumerable<Actor> Winners(Universe universe)
        {
            var threshold = universe.Population.Count;
            return universe.Population.Where(actor => actor.Score > threshold);
        }
    }
}
