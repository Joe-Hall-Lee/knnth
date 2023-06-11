using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01
{
    // This class is a super class
    class Animal
    {
        /// <summary>
        /// Describe how hungry this animal is
        /// </summary>
        protected int hunger;

        protected float energy = 10;

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
        public void Eat()
        {
            if (hunger > 3)
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
    }
}
