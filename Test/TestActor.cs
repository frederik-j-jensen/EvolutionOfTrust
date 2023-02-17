using EvolutionOfTrust.Actors;
using EvolutionOfTrust.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class TestActor : Actor
    {
        public int MoveCount = 0;
        public Move ChooseThisMove;

        public TestActor(Move move)
        {
            ChooseThisMove = move;
        }

        public override Move ChooseMove(History history)
        {
            MoveCount++;
            return ChooseThisMove;
        }

        public override Actor DoClone()
        {
            throw new NotImplementedException();
        }
    }
}
