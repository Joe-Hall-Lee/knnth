using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02
{
    class Player
    {

        // Data fields
        // For example speed, health, damage
        #region Fields

        // Is by defalut private
        // This variable is only accessable from within this class
        private int health;

        // public, this is accessable from everywhere.
        // We can read, and can write to it.
        // public fields goes against encapsulation. We want to decide when and where the values are changed.
        private float speed;


        #endregion

        // Properties
        // We use these to access fields
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

        #region Construtors

        public Player()
        {
            health = 100;
            speed = 10;

            Console.WriteLine("Player created");
        }

        public Player(int health, float speed)
        {
            this.health = health;
            this.speed = speed;

            Console.WriteLine("Player created with parameters");
        }
        #endregion
        #region Methods
        // Methods describe what the class can do.
        // Drive, Shoot, Die, Jump

        public int TakeDamage(int damage)
        {
            health -= damage;
            if (health < 0)
            {
                health = 0;
            }
            Console.WriteLine($"The player has {health} left");
            return health;
            // Take dmg animation
            // Death animation
            // Despawn the player
        }


        public void Jump()
        {
            Console.WriteLine("I'm jumping");
            // This is an action so it's not possible to do it with a property
            // Move the player up
            // Move it back down
            // Check for walls etc.
        }


        public void Run()
        {
            Console.WriteLine("I'm running");
        }

        public void Attack()
        {
            Console.WriteLine("I'm attacking");
        }
        #endregion
    }
}