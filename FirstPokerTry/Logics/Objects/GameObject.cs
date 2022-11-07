using System;

namespace FirstPokerTry.Logics.Objects
{
    public class GameObject
    {
        #region Properties

        private readonly int _id;
        private int _pot;

        #endregion

        public GameObject(int id, int pot)
        {
            _id = id;
            _pot = pot;
        }
    }
}

