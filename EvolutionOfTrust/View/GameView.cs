using EvolutionOfTrust.Model;
using System.Text;

namespace EvolutionOfTrust.View
{
    public class GameView
    {
        private UniverseView UniverseView;
        private State GameState;
        private Parameters Parameters;

        public GameView(Universe universe, State gameState, Parameters parameters)
        {
            GameState = gameState;
            UniverseView = new UniverseView(universe);
            Parameters = parameters;
        }

        public string Summary()
        {
            var s = new StringBuilder();

            s.AppendLine($"Turn: {1 + GameState.Turn}");
            s.AppendLine(UniverseView.Summary());

            return s.ToString();
        }

        public string Detailed()
        {
            var s = new StringBuilder();

            s.AppendLine($"Turn: {1 + GameState.Turn}");
            s.AppendLine(UniverseView.Details());

            return s.ToString();
        }

        public string ParametersView()
        {
            var s = new StringBuilder();

            s.AppendLine($"{nameof(Parameters.NumberOfTurns)}: {Parameters.NumberOfTurns}");
            s.AppendLine($"{nameof(Parameters.NumberOfRounds)}: {Parameters.NumberOfRounds}");
            s.AppendLine($"{nameof(Parameters.ProbabilityOfMistakePercent)}: {Parameters.ProbabilityOfMistakePercent}");
            s.AppendLine($"{nameof(Parameters.Seed)}: {Parameters.Seed}");

            return s.ToString();
        }

        public IEnumerable<Actor> Winners()
        {
            return UniverseView.Winners();
        }
    }
}
