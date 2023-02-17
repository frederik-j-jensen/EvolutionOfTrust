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

            s.AppendLine($"Turn: {GameState.Turn}");
            s.AppendLine(UniverseView.Summary());

            return s.ToString();
        }

        public string Detailed()
        {
            var s = new StringBuilder();

            s.AppendLine($"Turn: {GameState.Turn}");
            s.AppendLine(UniverseView.Details());

            return s.ToString();
        }

        public string ParametersView()
        {
            var s = new StringBuilder();

            s.AppendLine($"NumberOfTurns: {Parameters.NumberOfTurns}");
            s.AppendLine($"NumberOfRounds: {Parameters.NumberOfRounds}");
            s.AppendLine($"ProbabilityOfMistakePercent: {Parameters.ProbabilityOfMistakePercent}");

            return s.ToString();
        }
    }
}
