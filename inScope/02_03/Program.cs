using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool redKey = false;
            bool blueKey = false;
            bool greenKey = true;

            if (redKey)
            {
                Console.WriteLine("You can enter the red door!");
            }

            if (blueKey)
            {
                Console.WriteLine("You can enter the blue door!");
            }

            if (greenKey)
            {
                Console.WriteLine("You can enter the green door!");
            }
            if (blueKey && greenKey && greenKey)
            {
                Console.WriteLine("You can enter the rainbow door!");
            }
            if (redKey || blueKey || greenKey)
            {
                Console.WriteLine("You can enter the universal door!");
            }

            Random rnd = new Random();

            int first = 2; // rnd.Next(1, 11);
            int second = 7; // rnd.Next(1, 11);

            Console.WriteLine($"first random number is: {first}");
            Console.WriteLine($"second random number is: {second}");

            if ((first == 2 || first == 4 || first == 6 || first == 8 || first == 10)&& (second == 2 || second == 4 || second == 6 || second == 8 || second == 10))
            {
                Console.WriteLine("Both numbers are even");
            }
            else if ((first == 1 || first == 3 || first == 5 || first == 7 || first == 9) && (second == 1 || second == 3 || second == 5 || second == 7 || second == 9))
            {
                Console.WriteLine("Both numbers are odd");
            }
            else
            {
                // If the first number is even
                if (first == 2 || first == 4 || first == 6 || first == 8 || first == 10)
                {
                    Console.WriteLine("The first number is even");
                }
                else
                {
                    Console.WriteLine("The first number is odd");
                }
                // If the second number is even
                if (second == 2 || second == 4 || second == 6 || second == 8 || second == 10)
                {
                    Console.WriteLine("The second number is even");
                }
                else
                {
                    Console.WriteLine("The second number is odd");
                }
            }

            
        }
    }
}