using FirstPokerTry.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPokerTry.Logics.Objects;
using NUnit.Framework;

namespace FirstPokerTry.Logics.Gameplay
{
    public class DeckShuffle
    {
        private static Random random = new Random();

        public List<CardObject> CardList(List<CardObject> cards)
        {
            Shuffle(cards);
            return cards;
        }

        public static void Shuffle(List<CardObject> cards)
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                CardObject value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
    }
}


    
