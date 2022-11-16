#nullable disable

using System;
using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Logics.CardFactory.Classes
{
    public class Player : IPlayer
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        private PlayerObject PlayerObject { get; set; }

        #endregion

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Player() {}

        #region Methods

        public void SetPlayer(PlayerObject playerObject)
        {
            PlayerObject = playerObject;
        }

        #endregion
    }
}

