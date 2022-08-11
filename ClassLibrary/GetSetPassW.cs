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
        private string Pass;
        private string User;
        public void setPassword(string password)
        {
            this.Pass = password;
        }

        public string getPassword()
        {
            return Pass;
        }

        public void setUsername(string username)
        {
            User = username;
        }

        public string getUsername()
        {
            return User;
        }
    }

}
