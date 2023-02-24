using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Controller
{
    public class Tournament
    {
        private readonly Parameters Parameters;
        private readonly Random Random;

        public Tournament(Parameters parameters, Random random)
        {
            Parameters = parameters;
            Random = random;
        }

        public void Play(IEnumerable<Actor> actors)
        {
            var list = actors.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    var match = new Match(Parameters, Random);
                    match.Play(list[i], list[j]);
                }
            }
        }
    }
}