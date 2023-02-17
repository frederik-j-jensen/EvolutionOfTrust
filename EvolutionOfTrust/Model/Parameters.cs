namespace EvolutionOfTrust.Model
{
    public class Parameters
    {
        public int NumberOfTurns = 20;
        public int NumberOfRounds = 10; 
        public double ProbabilityOfMistakePercent = 0.0;
        public int Seed = 123123123;

        public int RewardCooporateOtherCooporate = 2; 
        public int RewardCooporateOtherCheat = -1;
        public int RewardCheatOtherCooperate = 3;
        public int RewardCheatOtherCheat = 0;
    }
}
