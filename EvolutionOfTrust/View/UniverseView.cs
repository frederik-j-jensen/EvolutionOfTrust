using EvolutionOfTrust.Model;
using System.Text;

namespace EvolutionOfTrust.View
{
    public class UniverseView
    {
        private Universe Universe;
        public UniverseView(Universe universe)
        {
            Universe = universe;
        }

        public string Summary()
        {
            var s = new StringBuilder();
            s.AppendLine($"Population: {Universe.Population.Count}");

            foreach (var pair in Distribution())
            {
                s.AppendLine($"{pair.Key}: {pair.Value}");
            }

            return s.ToString();
        }

        public string Details()
        {
            var s = new StringBuilder();
            s.AppendLine($"Population: {Universe.Population.Count}");

            foreach (var actor in Universe.Population)
            {
                s.AppendLine($" {actor}");
            }
            s.AppendLine();

            s.AppendLine("Winners:");
            foreach (var actor in Universe.Winners())
            {
                s.AppendLine( $" {actor}");
            }
            s.AppendLine();

            s.AppendLine("Loosers:");
            foreach (var actor in Universe.Loosers())
            {
                s.AppendLine($" {actor}");
            }

            return s.ToString();
        }

        private Dictionary<string, int> Distribution()
        {
            var result = new Dictionary<string, int>();

            foreach (var actor in Universe.Population)
            {
                if (result.ContainsKey(actor.Name))
                {
                    result[actor.Name]++;
                }
                else
                {
                    result.Add(actor.Name, 1);
                }
            }
            return result;
        }

    }
}
