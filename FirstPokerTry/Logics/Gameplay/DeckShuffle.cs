using FirstPokerTry.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Logics.Gameplay
{
    public class DeckShuffle
    {
        public List<CardObject> CardList()
        {
            var cardDeck = JsonFileReader.GetJsonData();
            Shuffle(cardDeck);
            return cardDeck;
        }


        public static void Shuffle(List<CardObject> a)
        {
            int n = a.Count;
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                swap(a, i, i + rand.Next(n - i));
            }
        }

        private static void swap(List<CardObject> a, int i, int v)
        {
            throw new NotImplementedException();
        }

        public static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b]; arr[b] = temp;
        }

    }
}


    
