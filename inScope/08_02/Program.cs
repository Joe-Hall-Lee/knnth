using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listUsers = new List<User>();

            Dictionary<string, User> dictionaryUsers = new Dictionary<string, User>();

            // Create 5 users
            User Keand = new User("KEAND", "Kenneth", "Anderson");
            User Jimto = new User("Jimto", "Jim", "Johnson");
            User Larto = new User("Larto", "Lars", "Larson");
            User Gityv = new User("Gityv", "Gitte", "Tysen");
            User Vira = new User("Vira", "Vita", "Anderson");

            // Adding to the list
            AddUniqueUser(listUsers, Keand);
            AddUniqueUser(listUsers, Jimto);
            AddUniqueUser(listUsers, Larto);
            AddUniqueUser(listUsers, Gityv);
            AddUniqueUser(listUsers, Vira);

            // Adding to the dictionary
            dictionaryUsers.Add(Keand.UserName, Keand);
            dictionaryUsers.Add(Jimto.UserName, Jimto);
            dictionaryUsers.Add(Larto.UserName, Larto);
            dictionaryUsers.Add(Gityv.UserName, Gityv);
            dictionaryUsers.Add(Vira.UserName, Vira);

            // This is input from the user
            string userName = "Larto";

            // Looking for a specific user in a list
            foreach (User user in listUsers)
            {
                if (user.UserName == userName)
                {
                    Console.WriteLine(user);
                }
            }

            // Looking for a specific user in a dictionary

            Console.WriteLine(dictionaryUsers["Hello"]);
        }

        public static void AddUniqueUser(Dictionary<string, User> users, User user)
        {
            if (!users.ContainsKey(user.UserName))
            {
                users.Add(user.UserName, user);
            }
            else
            {
                Console.WriteLine("User already exists");
            }
        }

        public static void AddUniqueUser(List<User> users, User user)
        {
            bool exists = false;

            foreach (User u in users)
            {
                if (u == user)
                {
                    exists = true;
                }
                if (!exists)
                {
                    users.Add(user);
                }
                else
                {
                    Console.WriteLine("User already exists");
                }
            }
        }
    }
}