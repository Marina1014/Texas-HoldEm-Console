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

            var deck = new CardDealer();
            var player1 = new Player();
            var player2 = new Player();

            player1.Hand = deck.DealPlayer1Hand();
            player2.Hand = deck.DealPlayer2Hand();

            gameDisplay.PrintDealtCards();

            var cardsOnTable = deck.DealFlop();
            gameDisplay.PrintCardsOnTable();

            var player1Turn = new PlayerTurn(player1, cardsOnTable);
            var player2Turn = new PlayerTurn(player2, cardsOnTable);

            player1Turn.PlayTurn();
            player2Turn.PlayTurn();

            var winner = new Winner(player1, player2, cardsOnTable);
            winner.DetermineWinner();
        }
    }
}

