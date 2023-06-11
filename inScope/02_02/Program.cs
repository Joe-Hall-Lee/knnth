using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;

            Console.WriteLine("Enter amount of damage to deal");

            int damage = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Original Health: {0}", health);

            Console.WriteLine("We are dealing: {0} damage", damage);

            // health = health - damage;

            health -= damage;

            Console.WriteLine("We have {0} health left", health);

            // WARNING SYSTEM
            Console.WriteLine("****WARNING SYSTEM****");
            if (health == 100)
            {
                Console.WriteLine("You have full health!");
            }
            else if (health >= 75 && health <= 99)
            {
                Console.WriteLine("You are almost at full health");
            }
            else if (health >= 50 && health <= 74)
            {
                Console.WriteLine("You are at medium health");
            }
            else if (health >= 25 && health <= 49)
            {
                Console.WriteLine("Your health is low");
            }
            else if (health >= 1 && health <= 24)
            {
                Console.WriteLine("Your health is critical");
            }
            else if (health <= 0)
            {
                Console.WriteLine("You are dead");
            }
        }
    }
}