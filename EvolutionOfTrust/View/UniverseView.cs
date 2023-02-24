using EvolutionOfTrust.Model;
using System.Collections.Immutable;
using System.Text;

namespace EvolutionOfTrust.View
{
    public class UniverseView
    {
        private Universe Universe;
        public int Turn { get { return Universe.Turn; } }
        public int Population { get { return Universe.PopulationCount; } }

        public UniverseView(Universe universe)
        {
            Universe = universe;
        }

        public string Summary()
        {
            var s = new StringBuilder();
            s.AppendLine($"Population: {Population}");

            foreach (var pair in Distribution().ToImmutableSortedDictionary())
            {
                s.AppendLine($"{pair.Key.PadRight(24)}: {pair.Value.ToString().PadLeft(4)}");
            }

            return s.ToString();
        }

        public string Details()
        {
            var s = new StringBuilder();
            s.AppendLine($"Population: {Population}");

            foreach (var actor in Universe.Population)
            {
                s.AppendLine($" {actor}");
            }
            s.AppendLine();

            s.AppendLine("Winners:");
            foreach (var actor in Universe.Winners())
            {
                s.AppendLine($" {actor}");
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
                var key = $"{actor.Name} {actor.Colour}";
                if (result.ContainsKey(key))
                {
                    result[key]++;
                }
                else
                {
                    result.Add(key, 1);
                }
            }
            return result;
        }

        public IEnumerable<Actor> Winners()
        {
            return Universe.Winners();
        }
    }
}
