#nullable disable

using System;
using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Logics.CardFactory.Classes
{
    public class Game : IGame
    {
        #region Properties

        public int Id { get; set; }
        public int Pot { get; set; }
        public Player Winner { get; set; }
        private GameObject GameObject { get; set; }

        #endregion

        public Game(int id, int pot, Player winner)
        {
            Id = id;
            Pot = pot;
            Winner = winner;
        }

        public Game() {}

        #region Methods

        public void SetGame(GameObject gameObject)
        {
            GameObject = gameObject;
        }

        #endregion
    }
}

