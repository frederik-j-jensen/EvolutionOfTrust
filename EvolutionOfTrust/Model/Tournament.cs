namespace EvolutionOfTrust.Model
{
    public class Tournament
    {
        public void Play(IEnumerable<Actor> actors)
        {
            var list = actors.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    var match = new Match();
                    match.Play(list[i], list[j]);
                }
            }
        }
    }
}