using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the x coordinate to place an X on");
            int xPos = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the y coordinate to place an Y on");
            int yPos = int.Parse(Console.ReadLine());

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (y == 0 && x != 0)
                    {
                        Console.Write($"[{x}]");
                    }
                    else if (x == 0 && y != 0)
                    {
                        Console.Write($"[{y}]");
                    }
                    else if (x == xPos && y == yPos)
                    {
                        Console.Write("[X]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}