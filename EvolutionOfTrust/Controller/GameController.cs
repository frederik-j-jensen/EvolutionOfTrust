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

        public void RunToEnd()
        {
            while (Step())
            PlayTournament();
        }

        public bool Step()
        {
            PlayTournament();
            ResolveTournament();
            return GameState.Turn < Parameters.NumberOfTurns;
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