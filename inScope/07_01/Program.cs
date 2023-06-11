using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            #region THEORY
            // Tiger tiger = new Tiger();

            // tiger.Jump();

            // if (tiger.MyHunger > 0)
            // {
            //     tiger.Eat();
            // }

            #endregion

            #region CHALLENGE

            Tiger t = new Tiger();

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
            #endregion
        }

        private static void TigerActions()
        {
            Tiger tiger = new Tiger();
            Console.WriteLine("You have chosen a tiger!");


            while (true)
            {
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: jump");
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
                    tiger.Jump();
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
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: fly");
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
                    bird.Fly();
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
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: swim");
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
                    fish.Swim();
                }

                fish.Status();
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}