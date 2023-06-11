using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04
{
    class Tiger : Animal
    {
        private int agility = 10;
        public Tiger(int agility, float energy) : base(energy)
        {
            this.agility = agility;
        }
        public override void Move()
        {
            if (energy > 0 && hunger < 5)
            {
                Console.WriteLine("I'm a tiger and I'm running");
            }

            base.Move();
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROOOAAARR");
        }

        public override void Eat()
        {
            if (hunger > 0)
            {
                Console.WriteLine("I'm a tiger and I'm eating meat");
            }
            base.Eat();
        }
    }
}