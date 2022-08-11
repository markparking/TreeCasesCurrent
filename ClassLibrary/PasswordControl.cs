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
        private string _username;
        public PassWordControl(string password)
        {
            _password = password;
           // _username = username;
        }
        //public PassUserControl(string username)
        //{
        //    _username = username;
        //}
        public bool upper1 = false;
        public bool Lower = false;
        public bool Number = false;
        public bool Symbol = false;
        public bool Short = false;
        public bool exists = false;
        public void ControlOK()
        {
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
            string lower = "abcdefghijklmnopqrstuvwxyzæøå";
            string symbol = "!#¤%&/()=?`^*_:;-.,'|}][{€$£@½<>";
            string number = "1234567890";


            //for (int i = 0; i <= _password.Length; i++)
            //{
                if (_password.Contains(upper))
                {
                upper1 = true;
                }
                else if (_password.Contains(lower))
                {
                Lower = true; 
                }
                else if (_password.Contains(symbol))
                {
                Symbol = true; 
                }
                else if (_password.Contains(number))
                {
                Number = true;
                }
                else if (_password.Length < 12)
                {
                Short = true;
                }
                else
                Console.WriteLine("Try again");
            //}
           
        }

        public void ExistingUser()
        {
            string datafil1 = @"c:\DataMappe\LoginFil.txt";
            string xUsername = File.ReadAllText(datafil1);

            if (!xUsername.Equals(_username))
            {
                Console.Clear();
                Console.WriteLine("There can be no more than 1 user of this program. Try again.");
            }
            else if (xUsername.Equals(_username))
            {
                exists = true;
            }


            
        
        }
    }
}
