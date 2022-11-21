using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using Newtonsoft.Json.Linq;
using FirstPokerTry.Logics.CardFactory.Enumerations;

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

        /*
        public List<CardObject> giveFlushList(List<CardObject> hand)
        {
            var flush = hand.GroupBy(c => c.Suit).Where(g => g.Count() == 5);
            //var suit = flush.First().Key;
            
            List<CardObject> suit = new List<CardObject>();
            

            return suit;
        }

        private static string ToString(SuitEnum suitEnum)
        {
            return suitEnum.ToString();
        }*/

        public bool checkIfStraightFlushExists(IEnumerable<CardObject> hand)
        {
            var handListHearts = hand.Where(o => o.Suit == SuitEnum.Hearts);
            var handListClubs = hand.Where(o => o.Suit == SuitEnum.Clubs);
            var handListSpades = hand.Where(o => o.Suit == SuitEnum.Spades);
            var handListDiamonds = hand.Where(o => o.Suit == SuitEnum.Diamonds);
            /*
            if (checkIfFlushExists(handList))
            {
                //handList = (List<CardObject>)handList.Where(o => o.Suit == suitEnum(handList));
                //IEnumerable<CardObject> enumerable = handList.Where(o => ToString((SuitEnum)(char)o.Suit) == ToString((SuitEnum)(char)suitEnum(handList)));
                //handList = enumerable as List<CardObject>;

                //IEnumerable<CardObject> shitList = handList.Where(o => ToString((SuitEnum)(char)o.Suit) == ToString((SuitEnum)(char)suitEnum(handList)));
                //handList = shitList as List<CardObject>;

            }*/
            if (handListHearts.Count() == 5) 
            {
                if (checkStraightForFlush(handListHearts))
                {
                    return true;
                }             
            } else if (handListClubs.Count() == 5)
            {
                if (checkStraightForFlush(handListClubs))
                {
                    return true;
                }               
            } else if (handListDiamonds.Count() == 5)
            {
                if (checkStraightForFlush(handListDiamonds))
                {
                    return true;
                }              
                
            } else if (handListSpades.Count() == 5)
            {
                if (checkStraightForFlush(handListSpades))
                {
                    return true;
                }
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

        public bool checkStraightForFlush(IEnumerable<CardObject> hand)
        {
            var handList = hand.OrderBy(c => c.rank).ToList();

            for (int i = 0; i < hand.Count() - 1; i++)
            {
                if (handList[i].rank == handList[i + 1].rank)
                {
                    handList[i].rank = 1;
                }
            }

            handList = hand.OrderBy(c => c.rank).ToList();

            return 
                    handList[4].rank - handList[0].rank == 4 ? true :
                        false;
        }

        public bool checkIfStraighExists(IEnumerable<CardObject> hand) 
        {
            var handList = hand.OrderBy(c => c.rank).ToList();

            for (int i = 0; i < handList.Count - 1; i ++)
            {
                if (handList[i].rank == handList[i + 1].rank)
                {
                    handList[i].rank = 1;
                }
            }

            handList = hand.OrderBy(c => c.rank).ToList();
            
            return handList[6].rank - handList[2].rank == 4 ? true :
                handList[5].rank - handList[1].rank == 4 ? true :
                    handList[4].rank - handList[0].rank == 4 ? true :
                        false;
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