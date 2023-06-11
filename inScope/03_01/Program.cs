using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte 0 to 255 - 256 - 1 byte
            byte myByte;

            // int -2.000.000.000 to max 2.000.000.000 - 4 bytes
            int myInt = 100;

            // Implicit - compilier handles it, we trust the compiler
            // myInt = myByte;

            // Explicit - We have to do something our self
            myByte = (byte)myInt; // Cast

            // Parse is used when the datatypes doesn't have anythinh in common
            // For example an int and string
            // Will throw an overflow exception on wrong format
            // Will throw an overflow exception on overflow
            byte age;
            string stringAge = "100";
            string oldAge = "Onehundred";

            // age = byte.Parse(stringAge);
            // age = byte.Parse(oldAge);

            // TryParse is used when the datatypes doesn't have anything in common
            // Will set the value to 0 on wrong format and overflow
            byte.TryParse(stringAge, out age);
            byte.TryParse(oldAge, out age);

            // Convert
            age = Convert.ToByte(stringAge);

            // Checked

            checked
            {
                // Game example
                byte health = 200;

                byte damage = 10;

                // Game starts and the hero takes 10 damage

                health -= damage;

                health += 100;
            }


        }
    }
}