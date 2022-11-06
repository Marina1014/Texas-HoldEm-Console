using System;
//using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.CardFactory.Enumerations;

namespace FirstPokerTry.Logics.Objects
{
    public class CardObject
    {

        #region Properties

        private readonly int _id;
        public SuitEnum Suit { get; }
        public ValueEnum Value { get; }
        private readonly int _rank;

        #endregion

        public CardObject(int Id, SuitEnum suit, ValueEnum value, int Rank)
        {
            _id = Id;
            Suit = suit;
            Value = value;
            _rank = Rank;
        }

        public override string ToString()
        {
            return $"{Suit}{Value}";
        }
    }
}

