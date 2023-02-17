namespace EvolutionOfTrust.Model
{
    public class Parameters
    {
        public int NumberOfTurns = 20;
        public int NumberOfRounds = 10; 
        public double ProbabilityOfMistakePercent = 5.0;

        public const int RewardCooporateOtherCooporate = 2; 
        public const int RewardCooporateOtherCheat = -1;
        public const int RewardCheatOtherCooperate = 3;
        public const int RewardCheatOtherCheat = 0;
    }
}
