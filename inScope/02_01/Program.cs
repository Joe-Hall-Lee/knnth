using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Your age is " + age);

            if(age > 17)
            {
                Console.WriteLine("Welcome to the program");
            }
            else
            {
                Console.WriteLine("You are not old enough");
            }
        }
    }
}