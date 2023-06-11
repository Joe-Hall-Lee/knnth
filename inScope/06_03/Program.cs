using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy(10, "Enemy1");
            Enemy e2 = new Enemy(10, "Enemy2");
            Enemy e3 = new Enemy(10, "Enemy3");
            Enemy e4 = new Enemy(10, "Enemy4");
            Enemy e5 = new Enemy(10, "Enemy5");

            e1.TakeDamage(105);
            Enemy.MyHealth -= 100;
            e1.Jump();
            e2.Jump();
            e3.Jump();
            e4.Jump();
            e5.Jump();
        }
    }
}