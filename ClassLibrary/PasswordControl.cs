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
        private string _password;
        private string path = @"c:\DataMappe";
        private string datafil = @"c:\DataMappe\LoginFil.txt";


        public PassWordControl(string password)
        {
            _password = password;
        }

        public void Kontrol1()
        {
            Password pass = new Password();
            string passinput = Convert.ToString(_password);
            Menu Menu = new Menu();

            bool containdigit = _password.Any(char.IsDigit);
            bool containlower = _password.Any(char.IsLower);
            bool containsupper = _password.Any(char.IsUpper);
            bool containssymbol = _password.Any(char.IsSymbol);
            bool lowerthantwelve = _password.Length >= 12;

            if (containdigit && containlower && containssymbol && containsupper && lowerthantwelve)
            {
                Menu.ProgramMain();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Password must have Upper and Lower case letters, symbols and numbers, and must be at least 12 cases long.");
                File.Delete(datafil);  
                Menu.CreateUserProfileMenu();
                Console.ReadKey();
            }
          
        }

        public void PassUserCreation()
        {
            // File.AppendText(pass.getPassword());
        }
        public void FileCreation()
        {
            if (!File.Exists(datafil))
            {
                Directory.CreateDirectory(path);

            }
        }



    }

}

