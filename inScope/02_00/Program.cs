using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your command: Run, Attack");

            string command = Console.ReadLine();

            if (command == "Attack")
            {
                Console.WriteLine("Attack Player");
            }
            if (command == "Run")
            {
                Console.WriteLine("Run away");
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hello and welcome to the program, please enter your gender");

            string gender = Console.ReadLine();

            if (gender == "Male")
            {
                Console.WriteLine("Hello Sir.");
            }
            if (gender == "Female")
            {
                Console.WriteLine("Hello Ma'am");
            }
        }
    }
}