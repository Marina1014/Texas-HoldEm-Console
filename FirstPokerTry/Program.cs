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
            var handChecker = new HandChecker();

            var cardDealer = new CardDealer();            
           
            Console.WriteLine(String.Join(", ", cardDealer.DealFirstThreeCards(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealPlayer1Hand(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealPlayer2Hand(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealNextCard(cardDeck)));
            Console.WriteLine(String.Join(", ", cardDealer.DealNextCard(cardDeck)));
            
            Console.WriteLine(String.Join(", ", cardDealer.getCardsPlayer1()));
            Console.WriteLine(String.Join(", ", cardDealer.getCardsPlayer2()));

            Console.WriteLine(handChecker.checkIfPairExists(cardDealer.getCardsPlayer1()));
            Console.WriteLine(handChecker.checkIfPairExists(cardDealer.getCardsPlayer2()));
        }
    }
}