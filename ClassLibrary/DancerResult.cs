using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    public class DancerResult
    {
        public static void DancersInput1()
        {
            Dancer dancer1 = new Dancer();
            Dancer dancer2 = new Dancer();
            DancerScore dancerScore1 = new DancerScore();
            DancerScore dancerScore2 = new DancerScore();

            Console.SetCursorPosition(95, 11);
            dancer1.SetDancerName(Console.ReadLine());
            Console.SetCursorPosition(95, 12);
            dancerScore1.SetDancerScore(Convert.ToInt32(Console.ReadLine()));
            Console.SetCursorPosition(95, 13);
            dancer2.SetDancerName(Console.ReadLine());
            Console.SetCursorPosition(95, 14);
            dancerScore2.SetDancerScore(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();

            Console.WriteLine(dancer1 + "scored " + dancerScore1);
            Console.WriteLine("and " + dancer2 + "scored " + dancerScore2);
            Console.WriteLine("The pair scored " + (dancerScore1) + (dancerScore2) + " Collectivly");
            Console.ReadKey();
        }
    }
}
