using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01
{
    // This class is a subclass
    // It inherits from Animal
    class Bird : Animal
    {
        /// <summary>
        /// Makes the birds fly
        /// </summary>
        public void Fly()
        {
            if (energy > 0 && hunger < 5)
            {
                hunger++;
                energy--;
                Console.WriteLine("I'm flying");
            }
            else if (hunger >= 5)
            {
                Console.WriteLine("I don't wanna do that, I am hungry");
            }
            else if (energy == 0)
            {
                Console.WriteLine("I don't have enough energy");
            }
        }
    }
}
