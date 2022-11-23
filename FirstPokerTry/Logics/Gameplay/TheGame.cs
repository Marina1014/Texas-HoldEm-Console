using FirstPokerTry.Data.Json;
using FirstPokerTry.Logics.CardFactory.Classes;
using FirstPokerTry.UI;
using static DryIoc.Setup;

namespace FirstPokerTry.Logics.Gameplay
{
    public class TheGame
    {
        public TheGame(int pot, int player1Pot, int player1Bet, int player2Pot, int player2Bet)
        {
            _pot = pot;
            _player1Pot = player1Pot;
            _player1Bet = player1Bet;
            _player2Pot = player2Pot;
            _player2Bet = player2Bet;
        }


        private int _player1Bet { get; set; }
        private int _player1Pot { get; set; }
        private int _player2Bet { get; set; }
        private int _player2Pot { get; set; }
        private int _pot { get; set; }


        public void PlayGame()
        {
            var gameDisplay = new GameDisplay(_pot, _player1Pot, _player1Bet, _player2Pot, _player2Bet);
            gameDisplay.PrintInitialGameMenu();

            var jsonCardDeck = JsonCardDeckFileReader.GetJsonCardDeck();
            var cardDealer = new CardDealer();
            var deckShuffle = new DeckShuffle();

            var cardDeck = deckShuffle.CardList(jsonCardDeck);
            //var player1 = new Player();
            //var player2 = new Player();

            //var player1Hand = player1.Hand;
            //var player2Hand = player2.Hand;

            var player1Hand = cardDealer.DealPlayer1Hand(cardDeck);
            var player2Hand = cardDealer.DealPlayer2Hand(cardDeck);

            //var player1HandString = CardObject.ToString(player1Hand); // IKKE SE 🙁

            gameDisplay.PrintDealtCards(player1Hand, player2Hand);

            gameDisplay.cardsOnTable = cardDealer.DealFirstThreeCards(cardDeck);
            gameDisplay.PrintCardsOnTable();

            // First betting round
            BettingRound(gameDisplay);

            // Draw 4th card
            cardDealer.DealNextCard(cardDeck);
            gameDisplay.PrintCardsOnTable();

            // Second betting round
            BettingRound(gameDisplay);

            // Draw 5th card
            cardDealer.DealNextCard(cardDeck);
            gameDisplay.PrintCardsOnTable();

            var winner = cardDealer.DetermineWinner();

            switch (winner)
            {
                case "player1":
                    gameDisplay.Player1Pot += gameDisplay.Pot;
                    Console.WriteLine($"Player 1 won {gameDisplay.Pot}");
                    break;
                case "player2":
                    gameDisplay.Player2Pot += gameDisplay.Pot;
                    Console.WriteLine($"Player 2 won {gameDisplay.Pot}");
                    break;
                default:
                    Console.WriteLine("Tie");
                    break;


            }
        }


        public void BettingRound(GameDisplay gameDisplay)
        {
            gameDisplay.PrintPlayersTurn(1);
            gameDisplay.PrintBetMenu();
            var player1Bet = gameDisplay.ReadBetInput();
            gameDisplay.Player1Pot -= player1Bet;
            gameDisplay.Pot += player1Bet;

            gameDisplay.PrintPlayersTurn(2);
            gameDisplay.PrintBetMenu();
            var player2Bet = gameDisplay.ReadBetInput();
            gameDisplay.Player2Pot -= player2Bet;
            gameDisplay.Pot += player2Bet;
        }
    }
}
