﻿using System;
using FirstPokerTry.Logics.CardFactory.Classes;
using System.Linq;
using FirstPokerTry.Logics.Objects;
using Newtonsoft.Json.Linq;

namespace FirstPokerTry.Logics.Gameplay
{
    public class HandChecker
    {


       
        public bool checkIfStraight (IEnumerable<CardObject> hand) 
        {
            var handList = hand.OrderBy(c => c._rank).ToList();
            handList.Distinct();

            if (handList[6]._rank - handList[2]._rank == 4 || handList[5]._rank - handList[1]._rank == 4 || handList[4]._rank - handList[0]._rank == 4)
            {
                return true;
            }

            return false;
        }

        public bool checkifFourOfAKindExists(IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.Value)
            .Where(g => g.Count() == 4)
            .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkifThreeOfAKindExists (IEnumerable<CardObject> hand)
        {
            if (hand.GroupBy(c => c.Value)
            .Where(g => g.Count() == 3)
            .Count() == 1)
            {
                return true;
            }

            return false;
        }

        public bool checkIfTwoPairsExists(IEnumerable<CardObject> hand)
        {

            if (hand.GroupBy(c => c.Value)
                       .Where(g => g.Count() == 2)
                       .Count() == 2)
            {
                return true;
            }

            return false;
        }

        public bool checkIfPairExists (IEnumerable<CardObject> hand)
        {
            
            if (hand.GroupBy(c => c.Value)
                       .Where(g => g.Count() == 2)
                       .Count() == 1) {
                return true;
            }
                       
            return false;
        }

        public int FindHighestValue (List<CardObject> hand)
        {
            return 1;
        }
    }
}