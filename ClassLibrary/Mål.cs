using System;
using System.Linq;
using System.Text.RegularExpressions;



namespace ClassLibrary
{
    public class Mål
    {
        public string[] checkMål = { "M", "Å", "L", "m", "å", "l", };
        public void Mål1()
        {
            Console.SetCursorPosition(95, 11);
           string _Mål = Console.ReadLine();
            if (Regex.IsMatch(_Mål, @"[!@#$%^&*(),.?:{ }|<>]"))
            {
                string johnjohn = "Please only use Letters.";
                Console.Clear();
                Console.WriteLine(johnjohn);
                Console.ReadKey();
            }
            else if (_Mål.Contains(checkMål[0]) | _Mål.Contains(checkMål[1]) | _Mål.Contains(checkMål[2]) | _Mål.Contains(checkMål[3]) | _Mål.Contains(checkMål[4]) | _Mål.Contains(checkMål[5]))
            {
                Console.Clear();
                string cunt = "Olé, Olé, Olé";
                Console.WriteLine(cunt);
            }
        }      
    }
}
