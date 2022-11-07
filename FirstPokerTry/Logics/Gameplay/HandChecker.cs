using System;
using System.Linq;

namespace FirstPokerTry.Logics.Gameplay
{
    public class HandChecker
    {
        public int FindHighestValue(int[] hand)
        {
            return hand.Max();
        }
    }
}

