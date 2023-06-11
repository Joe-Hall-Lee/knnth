using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick an animal: 1 for tiger, 2 for fish, 3 for bird");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    TigerActions();
                    break;

                case 2:
                    BirdActions();
                    break;

                case 3:
                    FishActions();
                    break;
            }
        }

        private static void TigerActions()
        {
            Tiger tiger = new Tiger();
            Console.WriteLine("You have chosen a tiger!");


            while (true)
            {
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: move");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    tiger.Eat();
                }
                else if (input == 2)
                {
                    tiger.Sleep();
                }
                else if (input == 3)
                {
                    tiger.Move();
                }

                tiger.Status();
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void BirdActions()
        {
            Bird bird = new Bird();
            Console.WriteLine("You have chosen a bird!");


            while (true)
            {
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: move");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    bird.Eat();
                }
                else if (input == 2)
                {
                    bird.Sleep();
                }
                else if (input == 3)
                {
                    bird.Move();
                }

                bird.Status();
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void FishActions()
        {
            Fish fish = new Fish();
            Console.WriteLine("You have chosen a fish!");


            while (true)
            {
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: move");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    fish.Eat();
                }
                else if (input == 2)
                {
                    fish.Sleep();
                }
                else if (input == 3)
                {
                    fish.Move();
                }

                fish.Status();
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}