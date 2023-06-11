using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();

            while (true)
            {
                Console.WriteLine("1. Inventory status");
                Console.WriteLine("2. Eat");
                Console.WriteLine("3. Drink");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        p.InventoryStatus();
                        break;
                    case 2:
                        p.Eat();
                        break;
                    case 3:
                        p.Drink();
                        break;
                }

                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}