using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_06
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyables = new IFlyable[] { new Plane(), new Bird() };

            foreach (IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
        }
    }
}