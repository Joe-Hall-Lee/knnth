using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] players = new string[3];
            // players[0] = "Joe";
            // players[1] = "Hans";
            // players[2] = "Jimmy";

            string[] players = new string[] { "Joe", "Hans", "Jimmy", "Kenneth", "Vita" };

            // This will give you an exeption called index out of bounds
            // The array's max index is 3
            // players[4] = "wadawd";

            // Console.WriteLine(players[0]);

            // Console.WriteLine(players[1]);

            // Console.WriteLine(players[2]);

            // for (int i = 0; i < players.Length; i++)
            // {
            //     Console.WriteLine(players[i]);
            // }

            // foreach (string playerName in players)
            // {
            //     Console.WriteLine(playerName);
            // }

            Console.WriteLine("Please enter the size of the array");
            string[] names;
            int size = int.Parse(Console.ReadLine());
            names = new string[size];

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Enter the names for index: " + i);
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("All the name!");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}