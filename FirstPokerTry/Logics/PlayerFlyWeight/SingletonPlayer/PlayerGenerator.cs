using System;
using System.Collections.Generic;
using FirstPokerTry.Logics.PlayerFlyWeight.Abstract;
using FirstPokerTry.Logics.PlayerFlyWeight.Players;
namespace FirstPokerTry.Logics.PlayerFlyWeight.SingletonPlayer
{
    public sealed class PlayerGenerator
    {
        #region Singleton Pattern

        private static PlayerGenerator _instance = new();

        private static readonly object SyncLock = new();

        public static PlayerGenerator GetInstance()
        {
            if (_instance == null)
            {
                lock (SyncLock)
                    _instance = new PlayerGenerator();
            }
            return _instance;
        }

        private PlayerGenerator()
        {

        }

        #endregion

        public readonly Dictionary<int, Player> Players = new();



        public Player Get(int id)
        {
            Player player;
            if (Players.ContainsKey(id))
                player = Players[id];
            else
            {
                switch (id)
                {
                    case 1:
                        player = new PlayerOne();
                        break;
                    case 2:
                        player = new PlayerTwo();
                        break;
                    case 3:
                        player = new PlayerThree();
                        break;
                    case 4:
                        player = new PlayerFour();
                        break;
                    default:
                        throw new IndexOutOfRangeException("There cannot be more than Four players");
                }
                Players.Add(id, player);
            }
            return player;
        }


    }
}

