using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_00
{
    internal class Program
    {
        static int age;

        static int lineNumber = 1;

        static int first;

        static int second;

        static void Main(string[] args)
        {
            // Method -  Used in object oriented programming, it's something that exists inside a class

            // Function - Found in scripts, does not have anything to do with objects

            // Welcome();

            // AskQuestion();

            // GetInput();

            // Response();

            // Challenge

            Add();

            Substract();

            Multiply();

            Divide();
        }

        static void Welcome()
        {
            WriteLineNumber();
            Console.WriteLine("Hello and welcome to the program!");
        }

        static void AskQuestion()
        {
            WriteLineNumber();
            Console.WriteLine("How old are you?");
        }

        static void GetInput()
        {
            WriteLineNumber();
            age = int.Parse(Console.ReadLine());
        }

        static void Response()
        {
            WriteLineNumber();
            Console.WriteLine($"Oh ok, you are {age} years old");
        }

        static void WriteLineNumber()
        {
            Console.Write(lineNumber + ". ");

            lineNumber++;
        }

        static void GetNumber()
        {
            Console.WriteLine("Please enter the first number");

            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");

            second = int.Parse(Console.ReadLine());
        }
        static void Add()
        {
            Console.WriteLine("Operation Add:");
            GetNumber();
            Console.WriteLine($"{first} + {second} is {first + second}");
            Console.WriteLine();
        }

        static void Substract()
        {
            Console.WriteLine("Operation Substract:");
            GetNumber();
            Console.WriteLine($"{first} - {second} is {first - second}");
            Console.WriteLine();
        }

        static void Divide()
        {
            Console.WriteLine("Operation Divide:");
            GetNumber();
            Console.WriteLine($"{first} / {second} is {first / second}");
            Console.WriteLine();
        }

        static void Multiply()
        {
            Console.WriteLine("Operation Multiply:");
            GetNumber();
            Console.WriteLine($"{first} * {second} is {first * second}");
            Console.WriteLine();
        }
    }
}