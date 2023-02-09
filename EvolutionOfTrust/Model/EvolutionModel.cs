
using EvolutionOfTrust.EvolutionModels;

namespace EvolutionOfTrust.Model
{
    public abstract class EvolutionModel
    {
        public abstract IEnumerable<Actor> Loosers(Universe universe);

        public abstract IEnumerable<Actor> Winners(Universe universe);

        public static EvolutionModel NCase() { return new NCase(); }
        public static EvolutionModel TournamentScore() { return new TournamentScore(); }
        public static EvolutionModel SCurve() { return new SCurve(); }

    }
}
