
using GameOfTrust.EvolutionModels;

namespace GameOfTrust.Model
{
    public abstract class EvolutionModel
    {
        public abstract IEnumerable<Actor> Loosers(Universe universe);

        public abstract IEnumerable<Actor> Winners(Universe universe);

        public static EvolutionModel Steady() { return new Steady(); }
        public static EvolutionModel Model1() { return new Model1(); }
        public static EvolutionModel SCurve() { return new SCurve(); }

    }
}
