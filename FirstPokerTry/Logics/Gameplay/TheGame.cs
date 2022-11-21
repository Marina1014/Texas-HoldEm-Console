using System;
using FirstPokerTry.Data.Json;
using FirstPokerTry.Logics.CardFactory.Classes;
using FirstPokerTry.Logics.Gameplay;
using FirstPokerTry.Logics.Objects;
using FirstPokerTry.UI;

namespace FirstPokerTry.Logics.Gameplay
{
    public class TheGame
    {
        private int _pot { get; set; } = 0;
        private int _player1Pot { get; set; } = 1000;
        private int _player1Bet { get; set; } = 0;
        private int _player2Pot { get; set; } = 1000;
        private int _player2Bet { get; set; } = 0;
        public bool Player1Turn;
        public bool Player2Turn;

        public TheGame(int Pot, int Player1Pot, int Player1Bet, int Player2Pot, int Player2Bet)
        {
            _pot = Pot;
            _player1Pot = Player1Pot;
            _player1Bet = Player1Bet;
            _player2Pot = Player2Pot;
            _player2Bet = Player2Bet;
        }

        public void PlayGame()
        {
            var gameDisplay = new GameDisplay(_pot, _player1Pot, _player1Bet, _player2Pot, _player2Bet);
            gameDisplay.PrintInitialGameMenu();

            var jsonCardDeck = JsonCardDeckFileReader.GetJsonCardDeck();
            var cardDealer = new CardDealer();
            var deckShuffle = new DeckShuffle();

            var cardDeck = deckShuffle.CardList(jsonCardDeck); 
            var player1 = new Player();
            var player2 = new Player();

            player1.Hand = cardDealer.DealPlayer1Hand(cardDeck);
            player2.Hand = cardDealer.DealPlayer2Hand(cardDeck);

            gameDisplay.PrintDealtCards();

            var cardsOnTable = cardDealer.DealFirstThreeCards(cardDeck);
            gameDisplay.PrintCardsOnTable();

            //så kan runden begynne
            Player1Turn = true;
            while(Player1Turn == true)
            {
                gameDisplay.PrintPlayersTurn(1);
                if (gameDisplay.PrintPlayersTurn(1) == true)
                {
                    gameDisplay.PrintBetMenu();
                    _player1Bet = gameDisplay.Bet;
                    _player1Pot = _player1Pot - _player1Bet;
                    _pot = _pot + _player1Bet;
                    Player1Turn = false;
                }
                else
                {
                    Player1Turn = false;
                }
                //nå kommer det godsaker

            }
        }
    }
}

