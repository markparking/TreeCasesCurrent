using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.IO;

namespace TreeCases2
{
    public class program
    {

    public const string datafil = @"c:\DataMappe\LoginFil.txt";
       public static void Main(string[] args)
        {
        Start:
            Console.SetCursorPosition(60, 13);
            pass.getPassword = (Console.ReadLine());
            PassWordControl PassWordControl = new PassWordControl();
            Menu.LoginMenu();
            PassWordControl.ControlOK();

            if ((PassWordControl.NoUpperLower = true) || (PassWordControl.NoSymbolOrNumber = true))
            {
                Console.Clear();
                Console.WriteLine("Please use Upper and Lower cases, and either a Number or a Symbol in you password.");
                Console.ReadKey();
                Console.Clear();
                goto Start;

            }
            else if ((PassWordControl.UpperLower = true) && (PassWordControl.SymbolOrNumber = true))
            {
                if (!File.Exists(datafil))
                {
                    Directory.CreateDirectory(@"C:\DataMappe");
                    File.WriteAllText(datafil, pass.getPassword);

                }
                Console.Clear();
                Console.WriteLine("Your new user is now created");
            }

            PassWordControl.ControlCancel();
            PassWordControl.ControlAllOK();
            Console.ReadKey();
            goto Start;

           
            // Menu.MenuMain();
            Console.SetCursorPosition(80, 11);
            string check = Console.ReadLine();
            if(check.Any(char.IsLetter) | check.Any(char.IsSymbol))
            {
                Console.Clear();
                Console.WriteLine("Please only the numbers 1 or 2");
                Console.ReadKey();
                goto Start;
            }
            else if (check.Any(char.IsDigit))
            {
                int input = Convert.ToInt32(check);
                
                if(input >= 3)
                {
                    Console.Clear();
                    Console.WriteLine("Please only use 1 or 2");
                    Console.ReadKey();
                }
                if (input == 1)
                {
                    Menu.Menu2();
                    DancerResult.DancersInput1();
                    goto Start;
                }
                else if (input == 2)
                {
                    Menu.Menu1();
                    Mål.Mål1();
                    Passes.Passes1();
                    goto Start;
                }
            }

        }
    }
}
