using System.Collections.Immutable;

namespace EvolutionOfTrust.Model
{
    public class Universe
    {
        private readonly List<Actor> _Population = new List<Actor>();
        public IEnumerable<Actor> Population => _Population.ToImmutableList();
        public int PopulationCount { get { return _Population.Count; } }
        public int Turn { get; set; }

        public Universe(PopulationBuilder populationBuilder)
        {
            _Population.AddRange(populationBuilder.Create());
        }

        public IEnumerable<Actor> Winners()
        {
            return _Population.Where(actor => actor.Ranking.Equals(Rankings.Winner)).ToArray();
        }

        public IEnumerable<Actor> Loosers()
        {
            return _Population.Where(actor => actor.Ranking.Equals(Rankings.Looser)).ToArray();
        }

        public void EliminateLoosers()
        {
            foreach (var looser in Loosers())
                _Population.Remove(looser);
        }

        public void ReproduceWinners()
        {
            foreach (var winner in Winners())
                _Population.Add(winner.Clone());
        }
    }
}
