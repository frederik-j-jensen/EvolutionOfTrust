using GameOfTrust.Model;

namespace GameOfTrust.Actors
{
    public class CopyCat : Actor
    {
        public CopyCat() : base(nameof(CopyCat)) { }

        public override Move ChooseMove(History history)
        {
            return history.IsEmpty() ? Move.Cooperate : history.LastMove();
        }

        public override Actor Clone()
        {
            return new CopyCat();
        }
    }
}