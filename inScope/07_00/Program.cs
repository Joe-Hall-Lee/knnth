using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Tiger tiger = new Tiger();
            Fish fish = new Fish();

            bird.Eat();
            bird.Fly();
            bird.Sleep();

            tiger.Jump();
            tiger.Eat();
            tiger.Jump();

            fish.Eat();
            fish.Swim();
            fish.Sleep();
        }
    }
}