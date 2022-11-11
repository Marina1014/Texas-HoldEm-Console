using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using Newtonsoft.Json.Linq;

namespace FirstPokerTry.Logics.Gameplay
{
    public class HandChecker
    {
       
        public bool checkIfStraight(IEnumerable<CardObject> hand, int n)
        {
            var handList = hand.OrderBy(c => c.Value).ToList();

            return handList[n - 2].Value <= handList[n - 1].Value && checkIfStraight(handList, n - 1);
        }

        public bool checkifThreeOfAKindExists(IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.Value)
            .Where(g => g.Count() == 3)
            .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkIfPairExists(IEnumerable<CardObject> hand)
        {
            
            if (hand.GroupBy(c => c.Value)
                       .Where(g => g.Count() == 2)
                       .Count() == 1) {
                return true;
            }
                       
            return false;
        }

        public int FindHighestValue(List<CardObject> hand)
        {
            return 1;
        }
    }
}

