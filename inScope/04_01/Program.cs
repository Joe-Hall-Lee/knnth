using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add(10, 12, "John");
            // Add(3, 2, "Kenneth");
            // Add(5, 5, "Jim");
            // Add(2, 5, "John");

            // string name = "Jim";
            // int age = 30;

            // GreetNameAndAge(3, name);

            // Challenge
            AskQuestion("name");
            string name = Console.ReadLine();
            AskQuestion("age");
            int age = int.Parse(Console.ReadLine());
            GreetNameAndAge(age, name);
        }

        /// <summary>
        /// This function adds two numbers
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="name"></param>
        static void Add(int first, int second, string name)
        {
            int result = first + second;

            Console.WriteLine(result);
            Console.WriteLine($"Hello{name}");
        }

        static void GreetNameAndAge(int age, string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine($"You are {age} years old");
        }

        // Challenge
        static void AskQuestion(string data)
        {
            Console.WriteLine($"Please enter your {data}");
        }
    }
}