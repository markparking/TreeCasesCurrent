using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Passes
    {
        public string _Passes{ get; set; }
        public void Passes1()
        {
            Console.SetCursorPosition(95, 12);
            int passes = Convert.ToInt32(Console.ReadLine());                        
            if (passes > 1 & passes <= 9)
            {
                Console.Clear();
                string brah = String.Concat(Enumerable.Repeat("HUH! ", passes));
                Console.WriteLine(brah);
                Console.ReadKey();
            }
            else if (passes >= 10)
            {
                Console.Clear();
                string fuck = "HIGH FIVE - JUBEL!!!!";
                Console.WriteLine(fuck);
                Console.ReadKey();
            }
            else if (passes == 0)
            {
                Console.Clear();
                string shh1 = "Shh!";
                Console.WriteLine(shh1);
                Console.ReadKey();
            }          
        }
    }
}

