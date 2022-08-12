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
        private int check;
        public void MainMenu()
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
            check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    LoginMenu();
                    break;
                case 2:
                    CreateUserProfileMenu();
                    break;

                default:                
                    Console.Clear();
                    Console.WriteLine("Please only use 1 or 2");
                    Console.ReadKey();
                    break;
                    
            
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
        public static void ProgramMain()
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

        }
        public void LoginMenu()
        {

        }
        public void CreateUserProfileMenu()
        {
            
            Password password = new Password();
            
            string datafil = @"c:\DataMappe\LoginFil.txt";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(50, 11);
            Console.WriteLine("Create new user:");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Username:");
            password.setUsername(Console.ReadLine());
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Password:");
            password.setPassword(Console.ReadLine());
            PassWordControl passWordControl = new PassWordControl(password.getPassword());
            passWordControl.Kontrol1();

        }
        

    }
}  
    

