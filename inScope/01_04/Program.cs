using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Example of strings

            // Define our variable with type and identifier
            string name;

            // We assign data to the variable
            name = "Joe";

            string age;

            age = "30";

            Console.WriteLine("Hello my name is " + name + " I'm " + age + " years old");

            Console.WriteLine("Hello my name is {0} and I'm {1} years old", name, age);

            Console.WriteLine(name + " that's a nice name");
            Console.ReadLine();

            // Mailing label challenge

            string firstName = "Kenneth";

            string lastName = "Andersen";

            string address = "Gφrrilds alle 17";

            string city = "Randers";

            string country = "Denmark";

            string zip = "8920";

            Console.WriteLine("First name: {0} \nLast name: {1} \nAddress: {2} \nCity: {3} \nCountry: {4} \nZip: {5}", firstName,lastName,address,city,country,zip);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}