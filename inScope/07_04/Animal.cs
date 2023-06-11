using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_04
{
    abstract class Animal
    {
        /// <summary>
        /// Describe how hungry this animal is
        /// </summary>
        protected int hunger;

        protected float energy;

        // Protected will expose functionality to all inheriting classes and the owning class
        // Private only exposes functionality to the owning class
        // Public exposes functionality to the whole program
        public int MyHunger
        {
            get
            {
                return hunger;
            }
        }

        public float MyEnergy
        {
            get
            {
                return energy;
            }
        }

        public Animal(float energy)
        {
            this.energy = energy;
        }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            if (hunger > 0)
            {
                hunger--;
                energy++;
                Console.WriteLine("I'm eating");
            }
            else
            {
                Console.WriteLine("I'm not hungry");
            }

        }

        public void Sleep()
        {
            if (energy < 5)
            {
                energy++;
                Console.WriteLine("I'm not tired!");
            }
            energy++;
            Console.WriteLine("I'm sleeping");
        }

        public void Status()
        {
            Console.WriteLine($"My energy is {energy}, my hunger is {hunger}");
        }

        public virtual void Move()
        {
            if (energy > 0 && hunger < 5)
            {
                hunger++;
                energy--;
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