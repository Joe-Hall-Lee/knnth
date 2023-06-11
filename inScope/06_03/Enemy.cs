using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03
{
    class Enemy
    {
        private bool isAlive;

        /// <summary>
        /// The enemy's damage
        /// </summary>
        private int damage;

        /// <summary>
        /// The enemy's name
        /// </summary>
        private string name;

        private static int health;

        public static int MyHealth;

        /// <summary>
        /// The enemy's constructor
        /// </summary>
        /// <param name="damage">The enemy's damage</param>
        /// <param name="name"></param>
        public Enemy(int damage, string name)
        {
            this.damage = damage;
            this.name = name;
            health = 100;
        }

        /// <summary>
        /// Attack a player
        /// </summary>
        /// <param name="player">The player to attack</param>
        public void Attack(Player player)
        {
            Console.WriteLine($"{name} did {damage} damage to the Player");

            // Makes sure the player takes damage
            player.TakeDamage(damage);
        }


        public void Jump()
        {
            if (health <= 0)
            {
                Console.WriteLine($"{name} is dead IT CAN'T JUMP!!!");
            }
            else
            {
                Console.WriteLine($"{name} is jumping");
            }

        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            Console.WriteLine($"{name} took {damage} damage, the enemy has {health} health left");
        }
    }
}
