using EvolutionOfTrust.EvolutionModels;
using EvolutionOfTrust.PopulationBuilders;

namespace EvolutionOfTrust.Model
{
    public class Universe
    {
        private EvolutionModel EvolutionModel = EvolutionModel.NCase();

        private Actors _Population = new Actors();
        public ActorsView Population { get { return new ActorsView(_Population); } }

        public Universe()
        {
            var populationBuilder = PopulationBuilder.NCasePopulation6(Parameters.InitialPopulationSize);

            _Population.AddRange(populationBuilder.Create());
        }

        public void PlayTournament()
        {
            var tournament = new Tournament();
            tournament.Play(_Population);
        }

        public IEnumerable<Actor> Loosers()
        {
            return EvolutionModel.Loosers(this);
        }

        public void EliminateLoosers()
        {
            _Population.Remove(EvolutionModel.Loosers(this));
        }

        public IEnumerable<Actor> Winners()
        {
            return EvolutionModel.Winners(this);
        }

        public void ReproduceWinners()
        {
            _Population.AddRange(
                EvolutionModel.Winners(this).Select(actor => actor.Clone()).ToArray()
                );
        }

        public void ResetScores()
        {
            foreach (var actor in _Population)
                actor.Score = 0;
        }
    }
}
