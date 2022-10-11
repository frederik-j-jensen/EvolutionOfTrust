using System.Collections;

namespace GameOfTrust.Model
{
    public class Actors : IEnumerable<Actor>
    {
        public int Count { get { return _Actors.Count; } }

        private List<Actor> _Actors = new List<Actor>();

        public IEnumerator<Actor> GetEnumerator()
        {
            return _Actors.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Actors.GetEnumerator();
        }

        public void AddRange(IEnumerable<Actor> actors) { _Actors.AddRange(actors); }


        public void Remove(IEnumerable<Actor> actors)
        {
            foreach (var actor in actors) { _Actors.Remove(actor); }
        }

    }
}
