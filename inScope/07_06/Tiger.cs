using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_06
{
    class Tiger : Animal, IEatable
    {
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
            Console.WriteLine("The tiger eats");
        }
    }
}