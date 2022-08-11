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
        public static void Main(string[] args)
        {
        Start:
                                                                                                            //Problemer med at dokument overskrives hver gang.
            
            Menu.LoginMenu();
            string path = @"c:\DataMappe";
            string datafil = @"c:\DataMappe\LoginFil.txt";
            Console.SetCursorPosition(60, 12);
            Password password = new Password();
            password.setUsername(Console.ReadLine()); //Tager username
            Console.SetCursorPosition(60, 13);
            password.setPassword(Console.ReadLine()); //Tager Password
            PassWordControl PassWordControl = new PassWordControl(password.getPassword());

            if (File.Exists(datafil))
            {

                PassWordControl.ExistingUser();
                Console.WriteLine("Welcome 2");
                Console.ReadKey();
            }
            else if (!File.Exists(path) || !File.Exists(datafil)) // Hvis mappe og/eller datafil ikke eksisterer
            {
                Directory.CreateDirectory(path);
                File.WriteAllText(@"c:\DataMappe\LoginFil.txt", password.getUsername() + " " + password.getPassword());
                Console.Clear(); 
                PassWordControl.ControlOK();
                Console.ReadKey();
            }
            
            


            if (PassWordControl.upper1 == false || PassWordControl.Lower == false || PassWordControl.Number == false || PassWordControl.Symbol == false || PassWordControl.Short == false)
            {
                Console.Clear();
                Console.WriteLine("Please use Upper and Lower cases, and either a Number or a Symbol in you password.");
                Console.WriteLine("Password also needs to be atleast 12 characters long.");
                Console.ReadKey();
                goto Start;
            }
            else

            if (!File.Exists(path) || !File.Exists(datafil)) // Hvis mappe og/eller datafil ikke eksisterer
            {
                Directory.CreateDirectory(path);
                File.WriteAllText(@"c:\DataMappe\LoginFil.txt", password.getUsername() + " " + password.getPassword());
                Console.Clear();
                Console.WriteLine("Welcome");
                Console.ReadKey();
            }
            else if (File.Exists(datafil))
            {
                Console.Clear();
                File.WriteAllText(@"c:\DataMappe\LoginFil.txt", password.getPassword());
                Console.WriteLine("Welcome 2");
                Console.ReadKey();
            }
            PassWordControl.ExistingUser();



            Start2:


            Console.Clear();
            Menu.MenuMain();
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
                    goto Start2;
                }
                if (input == 1)
                {
                    Menu.Menu2();
                    DancerResult.DancersInput1();
                    goto Start2;
                }
                else if (input == 2)
                {
                    Menu.Menu1();
                    Mål.Mål1();
                    Passes.Passes1();
                    goto Start2;
                }
            }

        }
    }
}
