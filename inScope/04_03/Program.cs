using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keyword called out tells the compiler that the object/parameter will be initialized inside the function
            // Keyword called ref tells the compiler that the object/parameter is initialized before entering the function

            int substracted;
            int multiplied;
            int divided = 0;
            int added = AddSubstractMultiplyDivide(4, 3, out substracted, out multiplied, ref divided);

            Console.WriteLine($"The multiplied value is {multiplied}");
            Console.WriteLine($"The multiplied value is {substracted}");
            Console.WriteLine($"The multiplied value is {added}");
            Console.WriteLine($"The divided value is {divided}");
        }

        static int AddSubstractMultiplyDivide(int first, int second, out int substracted, out int multiplied, ref int divided)
        {
            divided = first / second;
            substracted = first - second;
            multiplied = first * second;
            return first + second;
        }
    }
}