using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using ClassLibrary;

namespace ClassLibrary
{
    public class PassWordControl
    {
        public string _Password { get; }
        public string _Username { get; }
        private string path = @"c:\DataMappe";
        private string datafil = @"c:\DataMappe\LoginFil.txt";
        public PassWordControl(string password, string username)
        {
            _Password = password;
            _Username = username;
            
        }
        public void Kontrol1()
        {
            Menu Menu = new Menu();
            bool containdigit = _Password.Any(char.IsDigit);
            bool containlower = _Password.Any(char.IsLower);
            bool containsupper = _Password.Any(char.IsUpper);
            bool containssymbol = _Password.Any(char.IsSymbol);
            bool lowerthantwelve = _Password.Length >= 12;

            if (containdigit && containlower && containssymbol && containsupper && lowerthantwelve)
            {
                FileCreation();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Password must have Upper and Lower case letters, symbols and numbers, and must be at least 12 cases long.");
                Console.ReadKey();
            }      
        }
        public void FileCreation()
        {  
            if (!File.Exists(datafil))
            {
                Password Password = new Password();
                User User = new User();
                Directory.CreateDirectory(path);
                File.WriteAllText(datafil, _Password + " " + _Username);
                Console.Clear();
                Console.WriteLine("New user now created");
                Console.ReadKey();
                Menu Menu = new Menu();
                Menu.ProgramMain();
            }
            else if (File.Exists(datafil))
            {
                File.Delete(datafil);
                File.AppendAllText(datafil, _Username + Environment.NewLine + _Password);
                Console.Clear();
                Console.WriteLine("New user now created");
                Console.ReadKey();
                Console.Clear();
                Menu Menu = new Menu();
                Menu.ProgramMain();
            }
        }
    }
}

