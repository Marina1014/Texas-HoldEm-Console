using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using Newtonsoft.Json.Linq;

namespace FirstPokerTry.Logics.Gameplay
{
    public class HandChecker
    {
        public bool checkIfRoyalFlushExits(IEnumerable<CardObject> hand)
        {
            var handList = hand.OrderBy(c => c.rank).ToList();
            if (handList[6].Value == CardFactory.Enumerations.ValueEnum.Ace && checkIfFlushExists(hand) && checkIfStraighExists(hand))
            {
                return true;
            }
            return false;
        }

        public bool checkIfStraightFlushExists(IEnumerable<CardObject> hand)
        {
            if (checkIfFlushExists(hand) && checkIfStraighExists(hand))
            {
                return true;
            }
            return false;
        }

        public bool checkifFourOfAKindExists(IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.rank)
            .Where(g => g.Count() == 4)
            .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkIfFullHouseExists(IEnumerable<CardObject> hand)
        {
            if (checkIfPairExists(hand) && checkifThreeOfAKindExists(hand))
            {
                return true;
            }

            return false;
        }

        public bool checkIfFlushExists(IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.Suit)
                .Where(g => g.Count() == 5)
                .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkIfStraighExists(IEnumerable<CardObject> hand)
        {
            var handList = hand.OrderBy(c => c.rank).ToList();
            handList.Distinct();

            if (handList[6].rank - handList[2].rank == 4 || handList[5].rank - handList[1].rank == 4 || handList[4].rank - handList[0].rank == 4)
            {
                return true;
            }

            return false;
        }

        public bool checkifThreeOfAKindExists (IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.rank)
                .Where(g => g.Count() == 3)
                .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkIfTwoPairsExists(IEnumerable<CardObject> hand)
        {

            if (hand.GroupBy(c => c.rank) 
                       .Where(g => g.Count() == 2)
                       .Count() == 2)
            {
                return true;
            }

            return false;
        }

        public bool checkIfPairExists (IEnumerable<CardObject> hand)
        {

            var grouped = hand.GroupBy(c => c.rank);
            var filtered = grouped.Where(grouped => grouped.Count() == 2);
            var count = filtered.Count();
            if (count == 1) {
                return true;
            }

            return false;
                       
        }

        //Burde denne droppes her? 
        public bool checkIfHighestValue (List<CardObject> hand)
        {
            if (checkIfPairExists(hand) || checkIfTwoPairsExists(hand) || checkifThreeOfAKindExists(hand) || checkIfStraighExists(hand) || checkIfFlushExists(hand) || checkifFourOfAKindExists(hand))
            {
                return false;
            }

            return true;
        }
    }
}