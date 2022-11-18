using System;
using FirstPokerTry.Data;

namespace FirstPokerTry.Logics.Gameplay
{
    public class TheGame
    {
        private int _pot { get; set; }
        private int _player1Pot { get; set; }
        private int _player1Bet { get; set; }
        private int _player2Pot { get; set; }
        private int _player2Bet { get; set; }

        public TheGame(int Pot, int Player1Pot, int Player1Bet, int Player2Pot, int Player2Bet)
        {
            _pot = Pot;
            _player1Pot = Player1Pot;
            _player1Bet = Player1Bet;
            _player2Pot = Player2Pot;
            _player2Bet = Player2Bet;
        }
    }
}

