using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01
{
    // This class is a subclass
    // It inherits from Animal
    class Fish : Animal
    {
        public void Swim()
        {
            if (energy > 0 && hunger < 5)
            {
                hunger++;
                energy--;
                Console.WriteLine("I'm swimming");
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
