using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_05
{
    class Bird : Animal
    {
        private int intellect;

        public Bird(int intellect, float energy) : base(10)
        {
            this.intellect = intellect;
        }

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

        public override void MakeSound()
        {
            Console.WriteLine("THE FISH MAKES NO SOUND");
        }
    }
}