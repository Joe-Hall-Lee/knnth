using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01
{
    class Program
    {
        private static List<HighScore> highScores = new List<HighScore>();
        static void Main(string[] args)
        {
            Random rnd = new Random();

            highScores.Add(new HighScore("Kenneth", rnd.Next(1, 100)));
            highScores.Add(new HighScore("John", rnd.Next(1, 100)));
            highScores.Add(new HighScore("Marie", rnd.Next(1, 100)));
            highScores.Add(new HighScore("Melanie", rnd.Next(1, 100)));
            highScores.Add(new HighScore("Ritch", rnd.Next(1, 100)));
            highScores.Add(new HighScore("Dave", rnd.Next(1, 100)));

            while (true)
            {
                Console.WriteLine("1. Add score");
                Console.WriteLine("2. Remove score");
                Console.WriteLine("3. View highscores");

                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("Enter name");

                    string name = Console.ReadLine();

                    int score = rnd.Next(1, 100);

                    highScores.Add(new HighScore(name, score));
                }
                else if(input == 2)
                {
                    Console.WriteLine("Enter number to remove");
                    ViewScores();
                    int remove = int.Parse(Console.ReadLine());
                    highScores.RemoveAt(remove - 1);
                }
                else if (input == 3)
                {
                    ViewScores();
                }

                Console.WriteLine("Press enter to try again!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void ViewScores()
        {
            highScores.Sort();
            int rank = 1;
            foreach (HighScore score in highScores)
            {
                Console.WriteLine($"{rank}: {score }");

                rank++;
            }
        }
    }
}