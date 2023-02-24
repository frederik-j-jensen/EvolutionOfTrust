using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.EvolutionModels
{
    /// <summary>
    /// An evolution model where the actors total score in each tournament decides whether they get eliminated or get to reproduce.
    /// </summary>
    public class TournamentScore : EvolutionModel
    {
        public override IEnumerable<Actor> Loosers(RankedActors population)
        {
            return population.Where(actor => actor.Score <= 0);
        }

        public override IEnumerable<Actor> Winners(RankedActors population)
        {
            var threshold = population.Count;
            return population.Where(actor => actor.Score > threshold);
        }
    }
}
