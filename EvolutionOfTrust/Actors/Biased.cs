﻿using EvolutionOfTrust.Model;

namespace EvolutionOfTrust.Actors
{
    public class Biased : Actor
    {
        public Biased() : this(Colours.Red) { }
        public Biased(Colours colour) : base(nameof(Biased) + colour) { Colour = colour; }

        public override Move ChooseMove(History history)
        {
            Colours otherColour = history.OtherColour(this);
            return otherColour.Equals(Colour) ? Move.Cooperate : Move.Cheat;
        }
        public override Actor DoClone()
        {
            return new Biased(Colour);
        }
    }
}
