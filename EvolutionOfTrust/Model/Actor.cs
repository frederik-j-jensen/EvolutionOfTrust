namespace EvolutionOfTrust.Model
{
    public abstract class Actor
    {
        public int Score { get; set; }
        public string Name { get; set; }
        public Colours Colour { get; set; }
        public Actor() : this(nameof(Actor)) { }
        public Actor(string name) : this(name, Colours.Blue) { }
        public Actor(string name, Colours colour)
        {
            Score = 0;
            Name = name;
            Colour = colour;
        }
        public virtual Move ChooseMove(History history)
        {
            return Move.Cooperate;
        }
        public Actor Clone()
        {
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

        public override bool Equals(object? obj)
        {
            var other = obj as Actor;
            if (other == null) { return false; }
            else
            {
                return other.Colour == Colour && other.Name.Equals(Name);
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
