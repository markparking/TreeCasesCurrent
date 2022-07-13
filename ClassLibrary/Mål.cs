using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace ClassLibrary
{
    public class Mål
    {
        public static void Mål1()
        {
            Console.SetCursorPosition(95, 11);
            string mål = Console.ReadLine();

            string[] checkMål = { "M", "Å", "L", "m", "å", "l", };


            if (Regex.IsMatch(mål, @"[!@#$%^&*(),.?:{ }|<>]"))
            {
                Console.Clear();
                Console.WriteLine("Please only use Letters.");
                Console.ReadKey();
                

            }
            else if (mål.Contains(checkMål[0]) | mål.Contains(checkMål[1]) | mål.Contains(checkMål[2]) | mål.Contains(checkMål[3]) | mål.Contains(checkMål[4]) | mål.Contains(checkMål[5]))
            {
                Console.Clear();
                Console.WriteLine("Olé, Olé, Olé");
            }
        }
    }
}
