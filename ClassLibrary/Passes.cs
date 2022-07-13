using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Passes
    {
        public static void Passes1()
        {
            Console.SetCursorPosition(95, 12);
            string passesCheck = Console.ReadLine();
            int passes;

            if (passesCheck.Any(char.IsLetter) | passesCheck.Any(char.IsSymbol))
            {
                Console.Clear();
                Console.WriteLine("Please only use numbers for passes.");
                Console.ReadKey();
            }
            else if(passesCheck.Any(char.IsDigit))
            {   
                passes = Convert.ToInt32(passesCheck);
                if (passes == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Shh!");
                    Console.ReadKey();
                }
                else if (passes >= 1 & passes <= 9)
                {
                    Console.Clear();
                    Console.WriteLine(String.Concat(Enumerable.Repeat("HUH! ", passes)));
                    Console.ReadKey();
                }
                else if (passes >= 10)
                {
                    Console.Clear();
                    Console.WriteLine("HIGH FIVE - JUBEL!!!!");
                    Console.ReadKey();
                }
            }    


            
        }
    }
}
