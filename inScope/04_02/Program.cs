using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = Add(3, 2);
            // string message = Multiply(10, 10);
            // Console.WriteLine(message);

            float result = AddFloat(2, 2);

            bool isEven = IsEven(result);

            if (isEven)
            {
                Console.WriteLine($"The number {result} is even");
            }
            else
            {
                Console.WriteLine($"The number {result} is odd");
            }
        }

        static int Add(int first, int second)
        {
            int result = first + second;

            return result;
        }

        static string Multiply(int first, int second)
        {
            if (first * second > 10)
            {
                return "Result is larger than 10";
            }
            else
            {
            return "Result is larger than 10";
            }
        }
        static void WriteRusult(int result)
        {
            Console.WriteLine($"The result is {result}");
        }

        // Challenge

        static float AddFloat(float first, float second)
        {
            return first + second;
        }

        static bool IsEven(float number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}