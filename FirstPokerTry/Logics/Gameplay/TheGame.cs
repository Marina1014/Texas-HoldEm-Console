using System;
using FirstPokerTry.Data;

namespace FirstPokerTry.Logics.Gameplay
{
    public class TheGame
    {
        private int pot = 0;
        private int potPlayer1 = 1000;
        private int potPayer2 = 1000;

        private CardDealer cardDealer = new CardDealer();
        
        public void Playthrough()
        {
            var cardDeck = JsonFileReader.GetJsonData();
            Console.WriteLine("Welcome to this awesome poker game! This is a two-player game, " +
                "grab your friend and start playing. To start, enter " + "start");
            String? input = Console.ReadLine();

            if (input == "start")
            {
                Console.WriteLine("Here are the cards on the table: " + string.Join(", ", cardDealer.DealFirstThreeCards(cardDeck)));
                Console.WriteLine("Here are the cards for player1: " + string.Join(", ", cardDealer.DealPlayerHand(cardDeck)));
            }
        }             
    }
}

