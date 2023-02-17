using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.View;

namespace EvolutionOfTrust
{
    public class Game
    {
        private GameView View;
        private GameController Controller;

        public Game(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            var universe = new Universe(populationBuilder, evolutionModel, parameters, random);
            var state = new State();
            Controller = new GameController(universe, state, parameters);
            View = new GameView(universe, state, parameters);
        }

        public Game(PopulationBuilder populationBuilder, EvolutionModel evolutionModel) : this(populationBuilder, evolutionModel, new Parameters(), new Random()) { }

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

        public IEnumerable<Actor> Winners()
        {
            return View.Winners();
        }
    }
}
