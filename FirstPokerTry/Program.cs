using FirstPokerTry.Data;
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
            var cardDeck = JsonCardDeckFileReader.GetJsonCardDeck();
            var cardDeck1 = new DeckShuffle();
            Console.WriteLine(String.Concat(cardDeck.Select(o => o.ToString())));
            Console.WriteLine(String.Join(", ", cardDeck1.CardList(cardDeck)));
        }
    }
}