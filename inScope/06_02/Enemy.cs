using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02
{
    class Enemy
    {
        private int damage;

        private string name;

        public Enemy(int damage, string name)
        {
            this.damage = damage;
            this.name = name;
        }

        public void Attack(Player player)
        {
            Console.WriteLine($"{name} did {damage} damage to the Player");

            player.TakeDamage(damage);
        }
    }
}
