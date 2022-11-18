using System;
//using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.CardFactory.Enumerations;

namespace FirstPokerTry.Logics.Objects
{
    public class CardObject
    {

        #region Properties

        public int _id;
        public SuitEnum Suit;
        public ValueEnum Value;
        public int _rank;

        #endregion

        public CardObject(int Id, SuitEnum suit, ValueEnum value, int Rank)
        {
            _id = Id;
            Suit = suit;
            Value = value;
            _rank = Rank;
        }

        public CardObject()
        {
       
        }

        public override string ToString()
        {
            return $"{Suit}{Value}{_rank}";
        }
    }
}

