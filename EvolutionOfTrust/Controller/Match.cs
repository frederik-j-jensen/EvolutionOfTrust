using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Controller
{
    public class Match
    {
        private readonly Parameters Parameters;
        private readonly Random Random;

        public Match(Parameters parameters, Random random)
        {
            Random = random;
            Parameters = parameters;
        }

        public void Play(Actor actor1, Actor actor2)
        {
            var history = new History(actor1, actor2);

            for (int i = 0; i < Parameters.NumberOfRounds; i++)
            {
                var move1 = Transmit(actor1.ChooseMove(history));
                var move2 = Transmit(actor2.ChooseMove(history));

                history.AddMove(move1, move2);

                if (move1.Equals(Move.Cooperate) && move2.Equals(Move.Cooperate))
                {
                    actor1.Score += Parameters.RewardCooporateOtherCooporate;
                    actor2.Score += Parameters.RewardCooporateOtherCooporate;
                }
                else if (move1.Equals(Move.Cheat) && move2.Equals(Move.Cheat))
                {
                    actor1.Score += Parameters.RewardCheatOtherCheat;
                    actor2.Score += Parameters.RewardCheatOtherCheat;
                }
                else if (move1.Equals(Move.Cooperate) && move2.Equals(Move.Cheat))
                {
                    actor1.Score += Parameters.RewardCooporateOtherCheat;
                    actor2.Score += Parameters.RewardCheatOtherCooperate;
                }
                else if (move1.Equals(Move.Cheat) && move2.Equals(Move.Cooperate))
                {
                    actor1.Score += Parameters.RewardCheatOtherCooperate;
                    actor2.Score += Parameters.RewardCooporateOtherCheat;
                }
                else
                {
                    throw new Exception($"Unexpected combination of moves: {move1} and {move2}");
                }
            }

        }

        private Move Transmit(Move move) => Random.NextDouble() * 100 < Parameters.ProbabilityOfMistakePercent
                ? move.Opposite() : move;
    }
}
