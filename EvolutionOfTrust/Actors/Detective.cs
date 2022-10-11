using GameOfTrust.Model;

namespace GameOfTrust.Actors
{
    public class Detective : Actor
    {
        public Detective() : base(nameof(Detective)) { }

        public override Move ChooseMove(History history)
        {
            switch (history.Count)
            {
                case 0: return Move.Cooperate;
                case 1: return Move.Cheat;
                case 2: return Move.Cooperate;
                case 3: return Move.Cooperate;
                default:
                    {
                        return history.Any(move => move.Equals(Move.Cheat)) ? history.LastMove() : Move.Cheat;
                    }
            }
        }

        public override Actor Clone()
        {
            return new Detective();
        }
    }
}