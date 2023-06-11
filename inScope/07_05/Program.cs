using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick an animal: 1 for tiger, 2 for fish, 3 for bird");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AnimalActions(new Tiger(10, 5), "You have chosen a tiger");
                    break;

                case 2:
                    AnimalActions(new Fish(20, 2), "You have chosen a fish");
                    break;

                case 3:
                    AnimalActions(new Bird(10, 20), "You have chosen a bird");
                    break;
            }
        }

        private static void AnimalActions(Animal animal, string message)
        {
            Console.WriteLine(message);

            animal.MakeSound();

            while (true)
            {
                Console.WriteLine("Choose an action, 1: eat, 2: sleep, 3: move");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    animal.Eat();
                }
                else if (input == 2)
                {
                    animal.Sleep();
                }
                else if (input == 3)
                {
                    animal.Move();
                }

                animal.Status();
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}