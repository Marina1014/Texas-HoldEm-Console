using System.Reflection;
using FirstPokerTry.Data.Json;
using FirstPokerTry.Logics.CardFactory.Classes;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.UI;

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


        public void BettingRound(GameDisplay gameDisplay)
        {
            var player1Pot = new Player().Pot;
            player1Pot = _player1Pot;
            var player1Bet = new Player().Bet;
            player1Bet = _player1Bet;

            var player2Pot = new Player().Pot;
            player2Pot = _player2Pot;
            var player2Bet = new Player().Bet;
            player2Bet = _player2Bet;               //kanskje sett en while i round som har bool fold?

            gameDisplay.PrintPlayersTurn(1);
            player1Bet = Bet(gameDisplay, player1Bet, player2Bet, player1Pot, 1);

            if (player1Bet == 0)
                EndGame(gameDisplay, player1Pot, player2Pot);

            gameDisplay.PrintPlayersBet(1, player1Bet);
            _player1Bet = player1Bet;
            player1Pot -= _player1Bet;
            _player1Pot = player1Pot;
            _pot += _player1Bet;
            gameDisplay.PrintPotStatus(_pot, _player1Pot, _player2Pot);

            gameDisplay.PrintPlayersTurn(2);
            player2Bet = Bet(gameDisplay, player1Bet, player2Bet, player2Pot, 2);

            if (player1Bet == 0)
                EndGame(gameDisplay, player1Pot, player2Pot);

            gameDisplay.PrintPlayersBet(2, player2Bet);
            _player2Bet = player2Bet;
            player2Pot -= _player2Bet;
            _player2Pot = player2Pot;
            _pot += _player2Bet;
            gameDisplay.PrintPotStatus(_pot, _player1Pot, _player2Pot);
        }

        public int Bet(GameDisplay gameDisplay, int player1Bet, int player2Bet, int playerPot, int playerNumber)
        {
            gameDisplay.PrintBetMenu();
            if (playerNumber == 1)
            {
                player1Bet = gameDisplay.ReadBetInput();
                player1Bet = gameDisplay.ValidateBetBasedOnMinimum(player1Bet, player2Bet, 1);
                player1Bet = gameDisplay.ValidateBetBasedOnPot(player1Bet, playerPot, 1);
                return player1Bet;
            }
            else if (playerNumber == 2)
            {
                player2Bet = gameDisplay.ReadBetInput();
                player2Bet = gameDisplay.ValidateBetBasedOnMinimum(player2Bet, player1Bet, 2);
                player2Bet = gameDisplay.ValidateBetBasedOnPot(player2Bet, playerPot, 2);
                return player2Bet;
            }
            else return 0;
        }

        public void EndGame(GameDisplay gameDisplay, int player1Pot, int player2Pot)
        {
            if (player1Pot > player2Pot)
            {
                player1Pot += _pot;
                gameDisplay.PrintUltimateWinner(1, player1Pot);
                Environment.Exit(0);
            }
            else if (player1Pot < player2Pot)
            {
                player2Pot += _pot;
                gameDisplay.PrintUltimateWinner(2, player2Pot);
                Environment.Exit(0);
            }
        }

        public void PlayGame()
        {
            var gameDisplay = new GameDisplay(_pot, _player1Pot, _player1Bet, _player2Pot, _player2Bet);

            gameDisplay.PrintInitialGameMenu();

            var jsonCardDeck = JsonCardDeckFileReader.GetJsonCardDeck();
            var deckShuffle = new DeckShuffle();
            var cardDeck = deckShuffle.CardList(jsonCardDeck);

            while (_player1Pot > 0 || _player2Pot > 0)
            {
                Round(gameDisplay, cardDeck);
            }
                EndGame(gameDisplay, _player1Pot, _player2Pot); //redundant?
        }

        public void Round(GameDisplay gameDisplay, List<CardObject> cardDeck)
        {
            var cardDealer = new CardDealer();

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
            // Third betting round
            BettingRound(gameDisplay);

            // Determine this rounds winner
            var winner = cardDealer.DetermineWinner();

            switch (winner)
            {
                case "player1":
                    _player1Pot += _pot;
                    gameDisplay.PrintWinner(1, _pot);
                    break;
                case "player2":
                    _player2Pot += _pot;
                    gameDisplay.PrintWinner(2, _pot);
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("No winner could be determined.");
                    var sharedPot = _pot / 2;
                    _player1Pot += sharedPot;
                    _player2Pot += sharedPot;
                    break;
            }
            _pot = 0;
            _player1Bet = 0;
            _player2Bet = 0;

            cardDealer.GetCardsBackInDeck(cardDeck);
            player1Hand.Clear();
            player2Hand.Clear();
            gameDisplay.cardsOnTable.Clear();
        }

    }

}