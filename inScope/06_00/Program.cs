using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_00
{
    // Classes
    class Program
    {
        static void Main(string[] args)
        {
            // We are going to turn the class into an object
            // This means that we are instantiating a tank or an objevt

            // The line creates a tank object
            Tank tank = new Tank();
            Tank tank2 = new Tank();

            Console.WriteLine(tank);

            Player player = new Player();

            Console.WriteLine(player);

        }
    }
}