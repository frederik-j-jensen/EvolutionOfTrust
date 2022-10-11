
namespace GameOfTrust.Model
{
    public class Move
    {
        public static readonly Move Cheat = new Move();
        public static readonly Move Cooperate = new Move();

        public Move Opposite()
        {
            return Equals(Cheat) ? Cooperate : Cheat;
        }
    }
}
