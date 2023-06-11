using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            // We are writing to the player.speed variable
            // player.MySpeed = 10;

            // We are reading the player.speed variable
            // Console.WriteLine($"The player's speed is: {player.MySpeed}");
            // Console.WriteLine($"The player's health is: {player.MyHealth}");

            Random rnd = new Random();

            while (player.IsAlive)
            {
                int damage = rnd.Next(1, 11);

                player.MyHealth -= damage;

                Console.WriteLine($"The player took {damage} damage, the player has {player.MyHealth} health left");
            }

            Console.WriteLine("GAME OVER!!!");
            Console.ReadLine();
        }
    }
}