using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    internal class Client : User
    {
        public Client(string name, string password, string email) : base(name, password, email)
        {
        }

        public Client()
        {

        }

        public override bool Authorize(string email, string password)
        {

            return Email == email && Password == password;
        }



    }
}
