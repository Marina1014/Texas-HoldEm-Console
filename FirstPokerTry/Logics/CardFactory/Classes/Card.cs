using System;
using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.Objects;

namespace FirstPokerTry.Logics.CardFactory.Classes
{
    public class Card : ICard
    {
        #region Properties

        public int Id { get; }
        public int Rank { get; }
        private CardObject? CardObject { get; set; }
        public List<CardObject>? CardDeck { get; }

        #endregion

        public Card(int id, List<CardObject> cardDeck)
        {
            Id = id;
            CardDeck = cardDeck;
        }

        #region Methods

        public void SetCard(CardObject cardObject)
        {
            CardObject = cardObject;
        }

        #endregion
    }
}

