using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionOfTrust.Model
{
    public class ActorsView : IEnumerable<Actor>
    {
        private static Random Random = new Random();

        private readonly Actors _Actors;
        public int Count { get { return _Actors.Count; } }

        public ActorsView(Actors actors)
        {
            _Actors = actors;
        }

        public IEnumerator<Actor> GetEnumerator()
        {
            return _Actors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Actors.GetEnumerator();
        }

        public IEnumerable<Actor> Bottom(int x)
        {
            var list = new List<Actor>(_Actors);
            list.Sort((a1, a2) => a1.Score.CompareTo(a2.Score));
            var threshold = list[x-1].Score;
            var candidates = list.Where(a => a.Score <= threshold).ToList();
            Shuffle(candidates);
            return candidates.Take(x);
        }

        public IEnumerable<Actor> Top(int x)
        {
            var list = new List<Actor>(_Actors);
            list.Sort((a1, a2) => a2.Score.CompareTo(a1.Score));
            var threshold = list[x - 1].Score;
            var candidates = list.Where(a => a.Score >= threshold).ToList();
            Shuffle(candidates);
            return list.Take(x);
        }

        public static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
