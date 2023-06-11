using Challenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Items
{
    class Apple : Item, IEatable
    {
        public int Eat()
        {
            return 5;
        }

        public override string ToString()
        {
            return "Apple";
        }
    }
}