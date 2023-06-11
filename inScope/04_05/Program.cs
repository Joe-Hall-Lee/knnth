using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add, press 2 to substract");

            int answer = int.Parse(Console.ReadLine());

            Console.WriteLine("Press 1 for int, press 2 for float");

            int dataType = int.Parse(Console.ReadLine());

            if (answer == 1) // Then we want to add
            {
                if (dataType == 1) // We are using an int
                {
                    (int first, int second) = AskInt();

                    Console.WriteLine($"The result is {Add(first, second)}");
                }
                else // We are using float
                {
                    (float first, float second) = AskFloat();

                    Console.WriteLine($"The result is {Add(first, second)}");
                }
            }
            else // We want to substract
            {
                if (dataType == 1) // We are using an int
                {
                    (int first, int second) = AskInt();

                    Console.WriteLine($"The result is {Substract(first, second)}");
                }
                else // We are using float
                {
                    (float first, float second) = AskFloat();

                    Console.WriteLine($"The result is {Substract(first, second)}");
                }
            }
        }

        static int Add(int first, int second)
        {
            Console.WriteLine("I'm adding ints");
            return first + second;
        }

        static float Add(float first, float second)
        {
            Console.WriteLine("I'm adding floats");
            return first + second;
        }

        static void Add(float first, int second)
        {
            Console.WriteLine("I'm adding a float and an int");
            Console.WriteLine(first + second);
        }

        static int Substract(int first, int second)
        {
            return first - second;
        }

        static float Substract(float first, float second)
        {
            return first - second;
        }

        static (int, int) AskInt()
        {
            Console.WriteLine("Enter the first int value");

            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second int value");

            int second = int.Parse(Console.ReadLine());

            return (first, second);
        }

        static (float, float) AskFloat()
        {
            Console.WriteLine("Enter the first float value");

            float first = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second float value");

            float second = float.Parse(Console.ReadLine());

            return (first, second);
        }
    }
}