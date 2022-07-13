using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class Password
    {
        private string _password;
        public string getPassword
        {
            get { return _password; }
            set { _password = value; }
        }
    }
    
}
