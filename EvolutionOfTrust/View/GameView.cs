using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.View
{
    public class GameView
    {
        private State _GameState;
        private UniverseView _UniverseView;

        public GameView(State gameState, Universe universe)
        {
            _GameState = gameState;
            _UniverseView = new UniverseView(universe);
        }

        public string Summary()
        {
            var s = new StringBuilder();

            s.AppendLine($"Turn: {_GameState.Turn}");
            s.AppendLine(_UniverseView.Summary());

            return s.ToString();
        }

        public string Detailed()
        {
            var s = new StringBuilder();

            s.AppendLine($"Turn: {_GameState.Turn}");
            s.AppendLine(_UniverseView.Details());

            return s.ToString();
        }

        public string ParametersView()
        {
            var s = new StringBuilder();

            s.AppendLine($"InitialPopulationSize: {Parameters.InitialPopulationSize}");
            s.AppendLine($"NumberOfTurns: {Parameters.NumberOfTurns}");
            s.AppendLine($"NumberOfRounds: {Parameters.NumberOfRounds}");
            s.AppendLine($"ProbabilityOfMistakePercent: {Parameters.ProbabilityOfMistakePercent}");

            return s.ToString();
        }
    }
}
