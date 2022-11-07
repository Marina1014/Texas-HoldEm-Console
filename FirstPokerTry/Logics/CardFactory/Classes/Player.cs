#nullable disable

using System;
using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.Objects;
using System.ComponentModel.DataAnnotations;

namespace FirstPokerTry.Logics.CardFactory.Classes
{
    public class Player : IPlayer
    {
        #region Properties

        [Key]
        public int Id { get; }
        public string Name { get; }
        private PlayerObject PlayerObject { get; set; }

        #endregion

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #region Methods

        public void SetUser(PlayerObject playerObject)
        {
            PlayerObject = playerObject;
        }

        #endregion
    }
}

