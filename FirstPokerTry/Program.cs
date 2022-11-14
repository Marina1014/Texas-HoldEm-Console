using FirstPokerTry.Data;
using FirstPokerTry.Logics.CardFactory.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using FirstPokerTry.Logics.Gameplay;

namespace FirstPokerTry
{
    class Program
    {

        // Main Method
        public static void Main(String[] args)
        {
            var cardDeck = JsonFileReader.GetJsonData();
            var cardDeck1 = new DeckShuffle();
            Console.WriteLine(String.Concat(cardDeck.Select(o => o.ToString())));
            Console.WriteLine(cardDeck1.CardList());
        }
    }
}