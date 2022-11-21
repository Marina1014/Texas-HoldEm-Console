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
        private int _pot { get; set; }
        private int _player1Pot { get; set; }
        private int _player1Bet { get; set; }
        private int _player2Pot { get; set; }
        private int _player2Bet { get; set; }
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
            var gameDisplay = new GameDisplay(_pot, _player1Pot, _player1Bet, _player2Pot, _player2Bet); //Henter alle metodene for UI
            gameDisplay.PrintInitialGameMenu(); //Velkomstmeny

            var jsonCardDeck = JsonCardDeckFileReader.GetJsonCardDeck(); //Henter kortstokk fra Json
            var cardDealer = new CardDealer(); //Henter alle metodene fra dealer
            var deckShuffle = new DeckShuffle(); //Henter alle metodene fra Shuffle

            var cardDeck = deckShuffle.CardList(jsonCardDeck); //Definerer kortstokken som skal brukes, den er stokket
            var player1 = new Player(); //Henter player 1
            var player2 = new Player(); //Henter player 2

            var player1Hand = player1.Hand; //Definerer hånd til spiller 1
            var player2Hand = player2.Hand; //Definerer hånd til spiller 2

            player1Hand = cardDealer.DealPlayer1Hand(cardDeck); //Gir kort til spiller 1
            player2Hand = cardDealer.DealPlayer2Hand(cardDeck); //Gir kort til spiller 2

            gameDisplay.PrintDealtCards(player1Hand, player2Hand); //Skriver ut kortene som er delt ut, bør ha "se bort" eller lignende

            var cardsOnTable = cardDealer.DealFirstThreeCards(cardDeck); //Legger kort på bordet
            gameDisplay.PrintCardsOnTable(cardsOnTable); // Skriver ut hvilke kort som ligger på bordet
            /*
            //så kan runden begynne
            Player1Turn = true;
            while(Player1Turn == true)
            {
                GameDisplay.PrintPlayersTurn(1);
                if (GameDisplay.PrintPlayersTurn(1) == true)
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
                }*/
                //nå kommer det godsaker

            //}
        }
    }
}

