using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // var values = NameAndAge();

            // (string, int) values = NameAndAge();

            // (string name, int age) values = NameAndAge();

            // Console.WriteLine($"My name is {values.name} and I'm {values.age} years old");

            (string name, int age, string gender) info = AskQuestions();

            Console.WriteLine($"My name is {info.name} and I'm {info.age} years old, my gender is {info.gender}");
        }

        // static (string, int) NameAndAge()
        // {
        //     return ("Kenneth", 31);
        // }

        static (string name, int age) NameAndAge()
        {
            return ("Kenneth", 31);
        }

        static (string name, int age, string gender) AskQuestions()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your gender");
            string gender = Console.ReadLine();

            return (name, age, gender);
        }
    }
}