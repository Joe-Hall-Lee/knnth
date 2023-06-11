using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_00
{
    enum WEEKDAY { MONDAY, TUESDAY, WENDSDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY };
    enum DIRECTION { NORTH = 1, SOUTH, EAST, WEST }
    class Program
    {
        static void Main(string[] args)
        {
            // WEEKDAY day;

            // day = WEEKDAY.THURSDAY;

            // Console.WriteLine((byte)day);

            // Console.WriteLine("Please enter the day you want");
            // Console.WriteLine("Press 1 to 7");

            // int input = int.Parse(Console.ReadLine());

            // day = (WEEKDAY)input;

            // Console.WriteLine(day);

            // switch (day)
            // {
            //     case WEEKDAY.MONDAY:
            //         Console.WriteLine("I hate mondays");
            //         break;
            //     case WEEKDAY.TUESDAY:
            //         Console.WriteLine("I like tuesdays");
            //         break;
            //     case WEEKDAY.WENDSDAY:
            //         Console.WriteLine("It's almost weekend");
            //         break;
            //     case WEEKDAY.THURSDAY:
            //         Console.WriteLine("Just one more day until weekend");
            //         break;
            //     case WEEKDAY.FRIDAY:
            //         Console.WriteLine("It's weekend when I'm off");
            //         break;
            //     case WEEKDAY.SATURDAY:
            //         Console.WriteLine("I like saturdays");
            //         break;
            //     case WEEKDAY.SUNDAY:
            //         Console.WriteLine("Sunday is ok");
            //         break;
            // }

            int x = 0, y = 0;
            while (true)
            {
                Console.WriteLine($"You current position is X: {x} Y: {y}");

                Console.WriteLine("Please pick a direction");

                Console.WriteLine("1. North, 2. South, 3. East, 4. West");

                int input = int.Parse(Console.ReadLine());

                DIRECTION dir = (DIRECTION)input;

                switch (dir)
                {
                    case DIRECTION.NORTH:
                        Console.WriteLine("Going up north!");
                        y++;
                        break;
                    case DIRECTION.SOUTH:
                        Console.WriteLine("Going down south");
                        y--;
                        break;
                    case DIRECTION.EAST:
                        Console.WriteLine("Moving to the east!");
                        x++;
                        break;
                    case DIRECTION.WEST:
                        x--;
                        break;
                }

                Console.WriteLine();
            }

        }
    }
}