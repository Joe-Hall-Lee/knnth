using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02
{
    // This class is a subclass
    // It inherits from Animal
    class Bird : Animal
    {
        public override void Move()
        {
            if (energy > 0 && hunger < 5)
            {
                Console.WriteLine("I'm a bird and I'm flying");
            }

            base.Move();
        }

        public override void Eat()
        {
            if (hunger > 0)
            {
                Console.WriteLine("I'm a bird and I'm eating bird seeds");
            }
            base.Eat();
        }
    }
}
