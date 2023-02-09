using System.Runtime.CompilerServices;

namespace EvolutionOfTrust.Model
{
    public class Match
    {
        private Random _Random = new Random();

        public void Play(Actor actor1, Actor actor2)
        {
            var historyActor1 = new History();
            var historyActor2 = new History();

            for (int i = 0; i < Parameters.NumberOfRounds; i++)
            {
                var move1 = Transmit(actor1.ChooseMove(historyActor2, actor2.Colour));
                var move2 = Transmit(actor2.ChooseMove(historyActor1, actor1.Colour));

                historyActor1.AddMove(move1);
                historyActor2.AddMove(move2);

                if (move1.Equals(Move.Cooperate) && move2.Equals(Move.Cooperate))
                {
                    actor1.Score += 2;
                    actor2.Score += 2;
                }
                else if (move1.Equals(Move.Cheat) && move2.Equals(Move.Cheat))
                {
                    actor1.Score += 0;
                    actor2.Score += 0;
                }
                else if (move1.Equals(Move.Cooperate) && move2.Equals(Move.Cheat))
                {
                    actor1.Score -= 1;
                    actor2.Score += 3;
                }
                else if (move1.Equals(Move.Cheat) && move2.Equals(Move.Cooperate))
                {
                    actor1.Score += 3;
                    actor2.Score -= 1;
                }
                else
                {
                    throw new Exception($"Unexpected combination of moves: {move1} and {move2}");
                }
            }
        }

        private Move Transmit(Move move) => _Random.Next(1000) < 10 * Parameters.ProbabilityOfMistakePercent
                ? move.Opposite() : move;
    }
}
