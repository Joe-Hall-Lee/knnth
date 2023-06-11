using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define two float variables
            float first = 0;
            float second = 0;

            Console.WriteLine("Enter the first number");

            // Int.Parse, takes the text from the console and turns it
            // into an float
            first = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter the second number");

            // We converts the next string input into an int
            second = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("The result of first + second is: {0}", first + second);
            Console.WriteLine("The result of first - second is: {0}", first - second);
            Console.WriteLine("The result of first / second is: {0}", first / second);
            Console.WriteLine("The result of first * second is: {0}", first * second);

        }
    }
}