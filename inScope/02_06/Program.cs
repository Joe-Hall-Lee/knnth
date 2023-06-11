using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A while runs based on a condition
            // bool run = true;

            // while (run)
            // {
            //     Console.WriteLine("We are running!");
            // }

            // int number = 10;

            // while (number > 0)
            // {
            //     Console.WriteLine(number);
            //     number--;
            // }
            // Console.WriteLine("We are done with the loop!");

            // int number = 0;

            // while (true)
            // {
            //     number++;
            //     Console.WriteLine(number);
            //     if (number == 100)
            //     {
            //         break;
            //     }
            // }

            // bool alive = false;

            // while (alive)
            // {
            //     Console.WriteLine("The player is alive");
            // }

            // do
            // {
            //     Console.WriteLine("The player is alive");
            // } while (alive);

            while (true)
            {
                Console.WriteLine("Enter the number to count from!");

                int from = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number to count to!");

                int to = int.Parse(Console.ReadLine());

                Console.WriteLine("Counting...");
                Console.WriteLine(from);

                while (from != to)
                {
                    
                    if (from < to)
                    {
                        from++;
                    }
                    else
                    {
                        from--;
                    }


                    Console.WriteLine(from);
                }

                Console.WriteLine("Do you wanna try again? Write yes or no");

                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}