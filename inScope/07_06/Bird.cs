using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_06
{
    class Bird : Animal, IFlyable, IEatable
    {
        // Abstract classes change what the sub class is
        // Turns the bird into an animal
        // An interface tells what the class can do
        private int health;

        public int Health
        {
            get
            {
                return health;
            }

            set
            {

            }
        }

        public void Eat()
        {
            Console.WriteLine("I'm using my beak to eat");
        }
        public void Fly()
        {
            Console.WriteLine("I'm using my wings to fly");
        }
    }
}