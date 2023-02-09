using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Controller
{
    public class GameController
    {
        Universe Universe;
        State GameState;

        public GameController(Universe universe, State gameState)
        {
            Universe = universe;
            GameState = gameState;
        }

        public void Run()
        {
            while (GameState.Turn < Parameters.NumberOfTurns) Step();
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