using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_01
{
    class HighScore : IComparable<HighScore>
    {
        public int Score { get; set; }

        public string Name { get; set; }

        public HighScore(string name, int score)
        {
            this.Score = score;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {Score}";
        }

        public int CompareTo(HighScore other)
        {
            if (Score > other.Score)
                return -1;
            else if (Score < other.Score)
                return 1;

            return 0;  
        }
    }
}