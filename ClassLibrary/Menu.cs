using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Menu
    {

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
        public static void MenuMain()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(50, 11);
            
            Console.WriteLine("Choose what program to run:");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Dance Competition (1)");
            Console.SetCursorPosition (50, 13); 
            Console.WriteLine("Cheer Generator (2)");
            
        }
        public static void LoginMenu()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(50, 11);

            Console.WriteLine("Login / Create User");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Username:");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Password:");


        }
    }  
    
    
}

