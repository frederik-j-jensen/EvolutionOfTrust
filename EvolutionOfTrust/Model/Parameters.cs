namespace EvolutionOfTrust.Model
{
    public class Parameters
    {
        public const int InitialPopulationSize = 25;
        public const int NumberOfTurns = 20;
        public const int NumberOfRounds = 10; // 10
        public const double ProbabilityOfMistakePercent = 50.0;

        public const int RewardCooporateOtherCooporate = 2; // 2
        public const int RewardCooporateOtherCheat = -1;
        public const int RewardCheatOtherCooperate = 3;
        public const int RewardCheatOtherCheat = 0;
    }
}
