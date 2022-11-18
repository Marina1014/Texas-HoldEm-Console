using System;
namespace FirstPokerTry.Logics.Objects
{
    public class Wallet
    {
        public int Balance { get; }

        public Wallet(int balance)
        {
            Balance = balance;
        }

        #region Overloads

        public static Wallet operator +(Wallet wallet, int value)
        {
            return new Wallet(wallet.Balance + value);
        }

        public static Wallet operator -(Wallet wallet, int value)
        {
            return new Wallet(wallet.Balance - value);
        }

        #endregion

        public override string ToString()
        {
            return "Balance: " + Balance;
        }
    }
}

