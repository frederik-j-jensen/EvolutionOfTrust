using GameOfTrust.Model;

namespace GameOfTrust.EvolutionModels
{
    /// <summary>
    /// An evolution model where the actors total score in each tournament decides whether they get elimiated or get to reproduce.
    /// </summary>
    public class TournamentScore : EvolutionModel
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
