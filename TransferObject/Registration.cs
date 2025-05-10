using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Registration
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Cpassword { get; set; }

        public Registration(string name, string user, string password, string cpassword) 
        {
            Name = name;
            User = user;
            Password = password;
            Cpassword = cpassword;
        }
    }
}
