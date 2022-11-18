using System;
using FirstPokerTry.Logics.Objects;
namespace FirstPokerTry.Logics.PlayerFlyWeight.Abstract
{
	public class Player
	{
        #region Properties

        public int Id { get; protected init; }
        public string Name { get; private set; }
        public Wallet Wallet { get; private set; }

        #endregion

        #region Methods

        public void SetExtrinsicPart(string name, Wallet wallet)
        {

            if (name.Length > 0)
                Name = name;

            Wallet = wallet;

        }

        public void AddWallet(int value)
        {
            Wallet += value;
        }

        protected void SetName(string name)
        {
            Name = name;
        }

        public void SubtractWallet(int value)
        {
            Wallet -= value;
        }

        public void SetWallet(int value)
        {
            Wallet = new Wallet(value);
        }


        #endregion

        public override string ToString()
        {
            return $"   Player {Id}: {Name} \n"
                + $"   Wallet: {Wallet.Balance}";
        }
    }
}

