using GameOfTrust.Model;

namespace GameOfTrust.Actors
{
    public class Grudger : Actor
    {
        public Grudger() : base(nameof(Grudger)) { }

        public override Move ChooseMove(History history)
        {            
            return history.Any(move => move.Equals(Move.Cheat)) ? Move.Cheat : Move.Cooperate;
        }

        public override Actor Clone()
        {
            return new Grudger();
        }
    }
}