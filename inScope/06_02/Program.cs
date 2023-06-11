using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theory
            // Player player = new Player();
            // Player otherPlayer = new Player(60, 15);

            // Console.WriteLine($"The player's speed is {otherPlayer.MySpeed}");
            // Console.WriteLine($"The player's health is {otherPlayer.MyHealth}");

            // int healthLeft = player.TakeDamage(10);
            // player.Attack();

            #endregion

            #region Challenge

            Player player = new Player();

            Enemy[] enemies = new Enemy[10];

            Random rnd = new Random();

            for (int i = 0; i < enemies.Length; i++)
            {
                int damage = rnd.Next(1, 11);
                enemies[i] = new Enemy(damage, "Enemy " + i);
            }
            
            while (player.IsAlive)
            {
                foreach (Enemy enemy in enemies)
                {
                    enemy.Attack(player);
                }
            }
            #endregion
        }
    }
}