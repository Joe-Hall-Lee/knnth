using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = "Chicken";

            if (animal == "Duck")
            {
                Console.WriteLine("The duck says quack!");
            }
            else if (animal == "Cow")
            {
                Console.WriteLine("The cow says moo!");
            }         
            else if (animal == "Horse")
            {
                Console.WriteLine("The horse says neigh!");
            }
            else if (animal == "Dof")
            {
                Console.WriteLine("The dog says woof!");
            }
            else if (animal == "Chicken")
            {
                Console.WriteLine("The chicken says cluck!");
            }

            switch (animal)
            {
                case "Duck":
                    Console.WriteLine("The duck says quack!");
                    break;
                case "Cow":
                    Console.WriteLine("The cow says moo!");
                    break;
                case "Dog":
                    Console.WriteLine("The duck says quack!");
                    break;
                case "Horse":
                    Console.WriteLine("The horse says neigh!");
                    break;
                case "Chicken":
                    Console.WriteLine("The chicken says cluck!");
                    break;
            }

            string faction = string.Empty;
            string race = string.Empty;
            string cls = string.Empty;
            string gender = string.Empty;

            Console.WriteLine("Pick your faction");

            Console.WriteLine("1. Horde\n2. Alliance");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    faction = "Horde";
                    break;
                case 2:
                    faction = "Alliance";
                    break;
            }

            Console.Clear();

            Console.WriteLine("Pick your race");

            Console.WriteLine("1. Troll\n2. Human\n3. Orc\n4. Elf\n5. Gnome");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    race = "Troll";
                    break;
                case 2:
                    race = "human";
                    break;
                case 3:
                    race = "Orc";
                    break;
                case 4:
                    race = "Elf";
                    break;
                case 5:
                    race = "Gnome";
                    break;
            }

            Console.Clear();

            Console.WriteLine("Pick your class");

            Console.WriteLine("1. Hunter\n2. Warrior\n3. Rogue\n4. Paladin\n5. Monk");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    cls = "Hunter";
                    break;
                case 2:
                    cls = "Warrior";
                    break;
                case 3:
                    cls = "Rogue";
                    break;
                case 4:
                    cls = "Paladin";
                    break;
                case 5:
                    cls = "Monk";
                    break;
            }

            Console.Clear();

            Console.WriteLine("Pick your gender");

            Console.WriteLine("1. Male\n2. Female");

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    gender = "Male";
                    break;
                case 2:
                    gender = "Female";
                    break;
            }

            Console.Clear();

            Console.WriteLine($"You have successfully created your character." + 
                $"\nYour faction is {faction}" + 
                $"\nYour race is {race}" +
                $"\nYour class is {cls}" +
                $"\nYour gender is {gender}");


            Console.WriteLine();
        }
    }
}