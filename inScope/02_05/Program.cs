using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // This how we execute a line of code x amount of times in a forloop
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine("Hello World");
            // }

            // // Counts from 0 to 9
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // // Counts down from 10 to 1
            // for (int i = 10; i > 0; i--)
            // {
            //     Console.WriteLine(i);
            // }

            // Random rnd = new Random();

            // int amount = rnd.Next(0, 11);

            // for (int i = 0; i < amount; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // Console.WriteLine($"Your loop just ran {amount} of times");

            // // This is how you can skip a single loop
            // for (int i = 0; i < 10; i++)
            // {
            //     if (i == 5)
            //     {
            //         continue;
            //     }

            //     Console.WriteLine(i);
            // }

            // for (int i = 0; i < 10; i++)
            // {
            //     if (i == 5)
            //     {
            //         break;
            //     }

            //     Console.WriteLine(i);
            // }

            Console.WriteLine("Enter the player's health");

            int health = int.Parse(Console.ReadLine());

            Console.WriteLine("How many hits should the player take?");

            int hits = int.Parse(Console.ReadLine());

            Console.WriteLine("How much damage per hit?");

            int damage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the player's dodge chance");

            int dodge = int.Parse(Console.ReadLine());

            Random random  = new Random();

            for (int i = 0; i < hits; i++)
            {
                int hitChance = random.Next(0, 100);

                if (hitChance < dodge)
                {
                    Console.WriteLine("The player dodged the attack!");
                    continue;
                }

                health -= damage;

                Console.WriteLine($"The player took a hit and has {health} left");

                if (health <= 0)
                {
                    Console.WriteLine("The player is dead");
                    break;
                }
            }

            Console.WriteLine($"The player survived with {health} health");
        }

    }
}