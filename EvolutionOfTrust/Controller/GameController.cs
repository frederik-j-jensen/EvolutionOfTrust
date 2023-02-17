using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Controller
{
    public class GameController
    {
        Universe Universe;
        State GameState;
        Parameters Parameters;

        public GameController(Universe universe, State state, Parameters parameters)
        {
            Universe = universe;
            GameState = state;
            Parameters = parameters;
        }

        public void Run()
        {
            while (GameState.Turn < Parameters.NumberOfTurns) Step();
            PlayTournament();
        }

        public void Step()
        {
            PlayTournament();
            ResolveTournament();
        }

        public void PlayTournament()
        {
            Universe.PlayTournament();
        }

        public void ResolveTournament()
        {
            Universe.EliminateLoosers();
            Universe.ReproduceWinners();
            Universe.ResetScores();
            GameState.Turn++;
        }
    }
}