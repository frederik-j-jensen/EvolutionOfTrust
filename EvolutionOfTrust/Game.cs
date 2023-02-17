using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.View;

namespace EvolutionOfTrust
{
    public class Game
    {
        private GameView View;
        private GameController Controller;

        public Game(PopulationBuilder populationBuilder, EvolutionModel evolutionModel)
        {
            var state = new State();
            var parameters = new Parameters();
            var random = new Random();
            var universe = new Universe(populationBuilder, evolutionModel, parameters, random);
            Controller = new GameController(universe, state, parameters);
            View = new GameView(universe, state, parameters);
        }

        public void PlayTurn()
        {
            Controller.PlayTournament();
        }

        public void ResolveTurn()
        {
            Controller.ResolveTournament();
        }

        public void RunToEnd()
        {
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
