﻿using System.Runtime.CompilerServices;

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

        private Move Transmit(Move move) => _Random.Next(1000) < 10 * Parameters.ProbabilityOfMistakePercent
                ? move.Opposite() : move;
    }
}
