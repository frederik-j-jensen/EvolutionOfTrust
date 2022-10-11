using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfTrust.Controller;
using GameOfTrust.Model;

namespace GameOfTrust.View
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

    }
}
