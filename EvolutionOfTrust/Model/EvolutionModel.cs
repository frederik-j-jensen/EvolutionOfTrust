
namespace GameOfTrust.Model
{
    public abstract class EvolutionModel
    {
        public abstract IEnumerable<Actor> Loosers(Universe universe);

        public abstract IEnumerable<Actor> Winners(Universe universe);

    }
}
