using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ClassLibrary
{
    public class PassWordControl
    {

        public static bool UpperLower;
        public static bool SymbolOrNumber;
        public static bool NoUpperLower;
        public static bool NoSymbolOrNumber;

            public bool Check1;
            public bool Check2;
            Password pass = new Password();
        public void ControlOK()
        {
            
            Console.SetCursorPosition(60, 13);
            pass.getPassword = (Console.ReadLine());

            if (Regex.IsMatch(pass.getPassword, @"[a - z]") & Regex.IsMatch(pass.getPassword, @"[A-Z]"))
            {
                UpperLower = true;
            }
            else if (Regex.IsMatch(pass.getPassword, @"[!@#$%^&*(),.?:{ }|<>]") | Regex.IsMatch(pass.getPassword, @"[0-9]"))
            {
                SymbolOrNumber = true;
            }


            if (pass.getPassword.Length < 12)
            {
                Console.Clear();
                Console.WriteLine("Password must be at least 12 characters long.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Regex.IsMatch(pass.getPassword, @"^((?![a - z]))") | Regex.IsMatch(pass.getPassword, @"^((?![A-Z]))"))
            {
                NoUpperLower = true;
            }
            else if (Regex.IsMatch(pass.getPassword, @"^((?![!@#$%^&*(),.?:{ }|<>]))") | Regex.IsMatch(pass.getPassword, @"^((?![0-9]))"))
            {
                NoSymbolOrNumber = true;
            }

        }
        public void ControlCancel()
        {

        }
        public void ControlAllOK()
        {
            string datafil = @"c:\DataMappe\LoginFil.txt";
            if ((NoUpperLower = true) || (NoSymbolOrNumber = true))
            {
                Console.Clear();
                Console.WriteLine("Please use Upper and Lower cases, and either a Number or a Symbol in you password.");
                Console.ReadKey();

            }
            //else if ((UpperLower = true) && (SymbolOrNumber = true))
            //{
            //        if (!File.Exists(datafil))
            //        {
            //        Directory.CreateDirectory(@"C:\DataMappe");
            //        File.WriteAllText(datafil, pass.getPassword);

            //        }
            //        Console.Clear();
            //        Console.WriteLine("Your new user is now created");
            //}
        }
    }
}
