using System;

namespace TowerDefense
{
    class TowerDefenseExcpetion : Exception
    {
        public TowerDefenseExcpetion()
        {
            
        }

        public TowerDefenseExcpetion(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseExcpetion
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}