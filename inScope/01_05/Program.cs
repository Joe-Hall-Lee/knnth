using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, race, myClass, strength, intellect, stamina, health, mana;

            // Read the user input

            Console.WriteLine("Hello and welcome to the character creater");

            Console.WriteLine("Please enter your name");

            name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your class");

            myClass = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your race");

            race = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your strength");

            strength = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your intellect");

            intellect = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your stamina");

            stamina = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your health");

            health = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please enter your mana");

            mana = Console.ReadLine();

            Console.Clear();

            // Print the message

            Console.WriteLine("** CHARACTER SHEET**");

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Race: {0}", race);
            Console.WriteLine("Class: {0}", myClass);
            Console.WriteLine("Strength: {0}", strength);
            Console.WriteLine("Stamina: {0}", stamina);
            Console.WriteLine("Intellect: {0}", intellect);
            Console.WriteLine("Health: {0}", intellect);
            Console.WriteLine("Mana: {0}", mana);

            Console.ReadLine();

        }
    }
}