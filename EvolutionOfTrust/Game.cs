using EvolutionOfTrust.Controller;
using EvolutionOfTrust.Model;
using EvolutionOfTrust.View;
using System.Text;

namespace EvolutionOfTrust
{
    public class Game
    {
        private GameView View;
        private GameController Controller;

        public Game(PopulationBuilder populationBuilder, EvolutionModel evolutionModel, Parameters parameters, Random random)
        {
            var universe = new Universe(populationBuilder);
            Controller = new GameController(universe, evolutionModel, parameters, random);
            View = new GameView(universe, parameters);
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
            Controller.PlayToEnd();
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

        public void Play(StringBuilder output)
        {
            output.AppendLine(ViewParameters());
            output.AppendLine(ViewSummary());

            PlayTurn();
            output.AppendLine(ViewDetails());
            ResolveTurn();
            output.AppendLine(ViewSummary());

            while (Controller.PlayTurn())
            {
                output.AppendLine(ViewSummary());
            }
        }
    }
}
