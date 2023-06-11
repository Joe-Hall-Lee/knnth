using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01
{
    class Player
    {
        #region Fields

        // Is by defalut private
        // This variable is only accessable from within this class
        private int health = 100;

        // public, this is accessable from everywhere.
        // We can read, and can write to it.
        // public fields goes against encapsulation. We want to decide when and where the values are changed.
        private float speed;


        #endregion

        #region Properties
        public float MySpeed
        {
            get
            {
                return speed;
            }
            set 
            {
                if (value <= 0)
                {
                    speed = value * -1;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public int MyHealth
        {
            get
            {
                return health;
            }

            set
            {
                health = value;

                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public bool IsAlive
        {
            get
            {
                // return health > 0;
                if (health > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        #endregion

        // Data fields
        // For example speed, health, damage

        // Properties
        // We use these to access fields
    }
}