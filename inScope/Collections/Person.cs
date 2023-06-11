using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

        public int CompareTo(Person other)
        {

            if (Age > other.Age)
                return 1;
            else if (Age < other.Age)
                return -1;

            return string.Compare(Name, other.Name);

            // If other is less than this return -1

            // If other is equal to this return 0

            // If other is more than this return 1
        }
    }
}