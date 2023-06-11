using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_05
{
    class Fish : Animal
    {
        private int stamina;

        public Fish(int stamina, float energy) : base(energy)
        {
            this.stamina = stamina;
        }

        public override void Move()
        {
            if (energy > 0 && hunger < 5)
            {
                Console.WriteLine("I'm a fish and I'm swimming");
            }

            base.Move();
        }

        public override void Eat()
        {
            if (hunger > 0)
            {
                Console.WriteLine("I'm a fish and I'm eating fish flakes");
            }
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("TWEET!");
        }
    }
}