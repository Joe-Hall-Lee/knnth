using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_06
{
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm using my jet engine to fly");
        }
    }
}