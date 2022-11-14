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
            var game = new TheGame();

            game.Playthrough();
            /*
            var cardDeck = JsonFileReader.GetJsonData();
            var cardDeck1 = new DeckShuffle();

            var cardDealer = new CardDealer();

            Console.WriteLine(String.Concat(cardDeck.Select(o => o.ToString())));
            
            Console.WriteLine(String.Join(", ", cardDealer.DealFirstThreeCards(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealPlayerHand(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealPlayerHand(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealNextCard(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealNextCard(cardDeck)));*/
        }
    }
}