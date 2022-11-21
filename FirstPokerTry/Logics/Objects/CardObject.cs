using System;
//using FirstPokerTry.Logics.CardFactory.Interfaces;
using FirstPokerTry.Logics.CardFactory.Enumerations;

namespace FirstPokerTry.Logics.Objects
{
    public class CardObject
    {

        #region Properties

        public int id;
        public SuitEnum Suit;
        public ValueEnum Value;
        public int rank;

        #endregion

        public CardObject(int Id, SuitEnum suit, ValueEnum value, int Rank)
        {
            id = Id;
            Suit = suit;
            Value = value;
            rank = Rank;
        }

        public CardObject()
        {
       
        }

        public override string ToString()
        {
            return $"{Suit}{Value}";
        }
    }
}

