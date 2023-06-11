using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List
            // Creation
            List<string> names = new List<string>();

            List<Person> people = new List<Person>();

            // Adding
            names.Add("Kenneth");
            names.Add("John");
            names.Add("Jane");
            names.Add("Andy");
            names.Add("Bethy");
            names.Add("Noa");
            names.Add("Peter");

            // Access via. index
            string firstName = names[0];

            // Looping through

            // for (int i = 0; i < names.Count; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }

            // Print the list unsorted
            // Console.WriteLine("UNSORTED");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Remove 1 name
            names.Remove("Kenneth");

            // Sort the list
            // names.Sort();
            // Console.WriteLine("SORTED");
            // Print the list sorted
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // Objects

            // Add object
            Person p = new Person("Kenneth", 30);

            people.Add(new Person("Jim", 33));
            people.Add(new Person("Andy", 12));
            people.Add(p);
            people.Add(new Person("Marie", 55));
            people.Add(new Person("Vita", 80));

            // foreach (Person person in people)
            // {
            //     Console.WriteLine(person);
            // }

            // Console.WriteLine("Removed Kenneth");

            // Remove specific object with object reference
            // people.Remove(p);

            List<Person> tmp = people.ToList();

            foreach (Person person in tmp)
            {
                if (person.Name == "Kenneth")
                {
                    people.Remove(person);
                }
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            // Sort objects

            #endregion
        }
    }
}