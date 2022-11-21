using System;
using FirstPokerTry.Logics.PlayerFlyWeight.Abstract;
using FirstPokerTry.Logics.PlayerFlyWeight.SingletonPlayer;

namespace FirstPokerTry.Logics
{
	public class WalletLogic
	{
        private readonly PlayerGenerator _generator = PlayerGenerator.GetInstance();

        public void AddBalance(int playerId, int amount)
        {
            Player player = _generator.Get(playerId);

            player.AddWallet(amount);
        }

        public void SubtractBalance(int playerId, int amount)
        {
            Player player = _generator.Get(playerId);

            player.SubtractWallet(amount);
        }
    }
}

