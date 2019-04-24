using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authentiacftion
{
    public class User
    {
        private string username;
        private string password;
        private string email;

        // A read-write instance property:
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        // A read-only static property:
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // A read-only static property:
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
