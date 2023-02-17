namespace EvolutionOfTrust.Model
{
    public abstract class Actor
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public Colours Colour { get; set; }
        public Actor() : this(nameof(Actor)) { }
        public Actor(string name)
        {
            Score = 0;
            Name = name;
            Colour = Colours.Blue;
        }
        public virtual Move ChooseMove(History history)
        {
            return Move.Cooperate;
        }
        public Actor Clone() {
            var actor = DoClone();

            actor.Colour = Colour;
            actor.Score = Score;
            actor.Name = Name;

            return actor;
        }

        public abstract Actor DoClone();

        public override string ToString()
        {
            return $"{Name} {Colour} ({Score})";
        }
    }
}
