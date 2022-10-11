using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTrust.Model
{
    public class ActorsView : IEnumerable<Actor>
    {
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
            return list.Take(x);
        }

        public IEnumerable<Actor> Top(int x)
        {
            var list = new List<Actor>(_Actors);
            list.Sort((a1, a2) => a1.Score.CompareTo(a2.Score));
            return list.TakeLast(x);
        }

    }
}
