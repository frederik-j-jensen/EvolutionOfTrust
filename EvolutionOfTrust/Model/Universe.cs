using EvolutionOfTrust.EvolutionModels;
using EvolutionOfTrust.PopulationBuilders;

namespace EvolutionOfTrust.Model
{
    public class Universe
    {
        private readonly EvolutionModel EvolutionModel;
        private readonly Parameters Parameters;
        private readonly Random Random;

        private Actors _Population = new Actors();

        public ActorsView Population { get { return new ActorsView(_Population, Random); } }

        public Universe(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            EvolutionModel = evolutionModel;

            Parameters = parameters;
            Random = random;

            _Population.AddRange(populationBuilder.Create());
        }

        public void PlayTournament()
        {
            var tournament = new Tournament(Parameters, Random);
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
