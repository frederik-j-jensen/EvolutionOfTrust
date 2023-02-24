using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Controller
{
    public class GameController
    {
        Universe Universe;
        Parameters Parameters;
        Random Random;
        EvolutionModel EvolutionModel;

        public GameController(Universe universe, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            Universe = universe;
            EvolutionModel = evolutionModel;
            Parameters = parameters;
            Random = random;
        }

        public void PlayToEnd()
        {
            while (PlayTurn()) ;
        }

        public bool PlayTurn()
        {
            PlayTournament();
            ResolveTournament();
            return Universe.Turn < Parameters.NumberOfTurns;
        }

        public void PlayTournament()
        {
            var tournament = new Tournament(Parameters, Random);
            tournament.Play(Universe.Population);

            DetermineLoosers();
            DetermineWinners();
        }

        private void DetermineWinners() {
            var actors = new RankedActors(Universe.Population, Random);
            var winners = EvolutionModel.Winners(actors);
            foreach (var actor in winners)
                actor.Ranking = Rankings.Winner;
        }

        private void DetermineLoosers() {
            var actors = new RankedActors(Universe.Population, Random);
            var loosers = EvolutionModel.Loosers(actors);
            foreach (var actor in loosers)
                actor.Ranking = Rankings.Looser;
        }

        public void ResolveTournament()
        {
            Universe.EliminateLoosers();
            Universe.ReproduceWinners();
            foreach (var actor in Universe.Population)
            {
                actor.Score = 0;
                actor.Ranking = Rankings.None;
            }
            Universe.Turn++;
        }
    }
}