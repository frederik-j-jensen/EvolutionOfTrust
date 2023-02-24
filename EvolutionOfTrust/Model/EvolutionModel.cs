using EvolutionOfTrust.Controller;
using EvolutionOfTrust.EvolutionModels;

namespace EvolutionOfTrust.Model
{
    public abstract class EvolutionModel
    {
        public abstract IEnumerable<Actor> Loosers(RankedActors population);

        public abstract IEnumerable<Actor> Winners(RankedActors population);

        public static EvolutionModel NCase() { return new NCase(); }
        public static EvolutionModel TournamentScore() { return new TournamentScore(); }
        public static EvolutionModel SCurve() { return new SCurve(); }

    }
}
