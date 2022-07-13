using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class Dancer
    {
        private string Name;
        public void SetDancerName(string name)
        {
            this.Name = name;
        }

        public string GetDancerName()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Dancer dancer &&
                   Name == dancer.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -904786212;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
    public class DancerScore
    {
        private int Score;
        public void SetDancerScore(int scores)
        {
            this.Score = scores;
        }
        public int GetDancersScore()
        {
            return Score;
        }

        public override bool Equals(object obj)
        {
            return obj is DancerScore score &&
                   Score == score.Score;
        }

        public override int GetHashCode()
        {
            return 553120637 + Score.GetHashCode();
        }
    }
    public class DancerResult
    {
        public static void DancersInput1()
        {
            Dancer dancer1 = new Dancer();
            Dancer dancer2 = new Dancer();
            DancerScore dancerScore1 = new DancerScore();
            DancerScore dancerScore2 = new DancerScore();

            Console.SetCursorPosition(97, 11);
            dancer1.SetDancerName(Console.ReadLine());
            Console.SetCursorPosition(97, 12);
            dancerScore1.SetDancerScore(Convert.ToInt32(Console.ReadLine()));
            Console.SetCursorPosition(97, 13);
            dancer2.SetDancerName(Console.ReadLine());
            Console.SetCursorPosition(97, 14);
            dancerScore2.SetDancerScore(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine(dancer1.GetDancerName() + " scored " + dancerScore1.GetDancersScore());
            Console.WriteLine("and " + dancer2.GetDancerName() + " scored " + dancerScore2.GetDancersScore());
            Console.WriteLine("The pair scored " + (dancerScore1.GetDancersScore() + dancerScore2.GetDancersScore()) + " collectivly.");
            Console.ReadKey();
            
        }
    }
}
