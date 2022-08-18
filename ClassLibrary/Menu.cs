using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class Menu
    {
        private string datafil = @"c:\DataMappe\LoginFil.txt";
        public string Password, Username;
        private string check;
        private string check2;
        public void MainMenu()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("Choose what program to run:");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Login Page(1)");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("Create New User(2)");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Input:");
                Console.SetCursorPosition(56, 14);
                check = Console.ReadLine();

                switch (check)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        CreateUserProfileMenu();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please only use 1 or 2");
                        Console.ReadKey();
                        MainMenu();
                        break;
                }
            }
        }
        public static void Menu1()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("Welcome to Hvidovre FC's Cheer Generator!");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("==== Menu ====");
            Console.SetCursorPosition(80, 11);
            Console.WriteLine("Mål");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("Passes");
            Console.SetCursorPosition(80, 13);
        }
        public static void Menu2()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("Welcome to the Dance Competition!");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("==== Menu ====");
            Console.SetCursorPosition(80, 11);
            Console.WriteLine("Dancer 1's Name:");
            Console.SetCursorPosition(80, 12);
            Console.WriteLine("Dancer 1's Score:");
            Console.SetCursorPosition(80, 13);
            Console.WriteLine("Dancer 2's Name:");
            Console.SetCursorPosition(80, 14);
            Console.WriteLine("Dancer 2's Score:");
        }
        public void ProgramMain()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Choose what program to run:");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Dance Competition (1)");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Cheer Generator (2)");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Input:");
            Console.SetCursorPosition(60, 14);
            check2 = Console.ReadLine();      

            switch (check2)
            {     
                case "2":
                    Mål Mål = new Mål();
                    Passes Passes = new Passes();
                    Menu1();
                    Mål.Mål1();
                    Passes.Passes1();
                    ProgramMain();
                    break;
                case "1":
                    Menu2();
                    DancerResult.DancersInput1();
                    ProgramMain();
                    break;               
                default:
                    Console.Clear();
                    Console.WriteLine("Please only use 1 or 2");
                    Console.ReadKey();
                    ProgramMain();
                    break;
            }
        }
        public void LoginMenu()
        {
            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Login:");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Username:");
            Console.SetCursorPosition(60, 12);
            Username = Console.ReadLine();
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Password:");
            Console.SetCursorPosition(60, 13);
            Password = Console.ReadLine();

            if(File.ReadAllLines(datafil).Contains(Username) && File.ReadAllText(datafil).Contains(Password))
            {
                Console.Clear();
                Console.WriteLine("Welcome back " + Username);
                Console.ReadKey();
                ProgramMain();
            }
            else if (!File.ReadAllLines(datafil).Contains(Username))
            {
                Console.Clear();
                Console.WriteLine("Wrong username. Try again.");
                Console.ReadKey();
                LoginMenu();
            }
            else if(!File.ReadAllLines(datafil).Contains(Password))
            {
                Console.Clear();
                Console.WriteLine("Wrong password. Try again.");
                Console.ReadKey();
                LoginMenu();
            }
        }
        public void CreateUserProfileMenu()
        {            
            Password password = new Password(); //Opretter nye objekter
            User user = new User();

            Console.BackgroundColor = ConsoleColor.Green; //Printer baggrund
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Create new user:");
            Console.SetCursorPosition(50, 12); 
            Console.WriteLine("Username:");
            Console.SetCursorPosition(60, 12);
            Username = Console.ReadLine(); //Tager Username
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Password:");
            Console.SetCursorPosition(60, 13);
            Password = Console.ReadLine(); //Tager Password
            PassWordControl passWordControl = new PassWordControl(Password, Username); //Opretter nyt object og giver variabler
            passWordControl.Kontrol1();
        }
    }
}


