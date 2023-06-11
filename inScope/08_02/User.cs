using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_02
{
    class User
    {

        public string UserName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public User(string userName, string firstName, string lastName)
        {
            this.UserName = userName;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return $"First name: {FirstName} LastName: {LastName}";
        }
    }
}