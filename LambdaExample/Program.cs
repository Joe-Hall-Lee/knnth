using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value = 3;

            // value = Calculate(value);

            Func<int, int> Calculate = value => value * 5;

            int result = Calculate(3);
            
        }


        // static int Calculate(int value)
        // {
        //     value = value * 5;
        //
        //     return value;
        // }
    }
}