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

            var player1Hand = new Player().Hand;
            var player2Hand = new Player().Hand;

            player1Hand = cardDealer.DealPlayer1Hand(cardDeck);
            player2Hand = cardDealer.DealPlayer2Hand(cardDeck);

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
                    _player1Pot += _pot;
                    gameDisplay.PrintWinner(1, _pot);
                    //Console.WriteLine($"Player 1 won {_pot}");
                    break;
                case "player2":
                    _player2Pot += _pot;
                    gameDisplay.PrintWinner(2, _pot);
                    //Console.WriteLine($"Player 2 won {_pot}");
                    break;
                default:
                    Console.WriteLine("No winner could be determined.");
                    break;
            }
        }

        public void BettingRound(GameDisplay gameDisplay)
        {
            var player1Pot = new Player().Pot;
            player1Pot = _player1Pot;
            var player1Bet = new Player().Bet;
            player1Bet = _player1Bet;

            var player2Pot = new Player().Pot;
            player2Pot = _player2Pot;
            var player2Bet = new Player().Bet;
            player2Bet = _player2Bet;

            //dette må settes i en while loop
            gameDisplay.PrintPlayersTurn(1);
            gameDisplay.PrintBetMenu();

            player1Bet = gameDisplay.ReadBetInput();
            player1Bet = gameDisplay.ValidateBetBasedOnMinimum(player1Bet, player2Bet, 1); //ny
            //gameDisplay.ValidateBetBasedOnPot(player1Bet, 1); //ny
            _player1Bet = player1Bet;
            player1Pot -= player1Bet;
            _player1Pot = player1Pot;
            _pot += player1Bet;
            gameDisplay.PrintPotStatus(_pot, player1Pot, player2Pot);

            gameDisplay.PrintPlayersTurn(2);
            gameDisplay.PrintBetMenu();
            player2Bet = gameDisplay.ReadBetInput();
            player2Bet = gameDisplay.ValidateBetBasedOnMinimum(player2Bet, player1Bet, 2); //ny
            //gameDisplay.ValidateBetBasedOnPot(player2Bet, 2); //ny
            _player2Bet = player2Bet;
            player2Pot -= player2Bet;
            _player2Pot = player2Pot;
            _pot += player2Bet;
            gameDisplay.PrintPotStatus(_pot, player1Pot, player2Pot);
        }
    }
}
