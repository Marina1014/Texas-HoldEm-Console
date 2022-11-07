using System;
namespace FirstPokerTry.Logics.Objects
{
    public class PlayerObject
    {
        #region Properties
        private readonly int _id;
        private string _name;
        #endregion

        public PlayerObject(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}

