using GameOfTrust.Controller;
using GameOfTrust.Model;
using GameOfTrust.View;

namespace GameOfTrust
{
    public class Game
    {
        GameView View;
        GameController Controller;
        Universe Universe;
        State State;

        public Game()
        {
            Universe = new Universe();
            State = new State();
            Controller = new GameController(Universe, State);
            View = new GameView(State, Universe);
        }

        public void PlayTurn() {
            Controller.PlayTournament();
        }

        public void ResolveTurn() {
            Controller.ResolveTournament();
        }

        public void RunToEnd() {
            Controller.Run();
        }

        public string ViewSummary()
        {
            return View.Summary();
        }

        public string ViewDetails()
        {
            return View.Detailed();
        }

        public string ViewParameters()
        {
            return View.ParametersView();
        }
    }
}
