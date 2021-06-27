using mouse.dl;
using System;
using System.Collections.Generic;
using System.Text;

namespace mouse.bl
{
    public class UserValidation
    {
        public List<User> UserCredentials = new List<User>()
        {
            new User("Franz","Maaba")
        };

        public void LogIn()
        {
            UserCatalogue catalogue = new UserCatalogue();
            bool successful = false;
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (User user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Log in Success");
                    successful = true;
                    catalogue.Catalogue();
                }
            }
            if (!successful)
            {
                Console.WriteLine("Operation Cease...");
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new User(userName, passWord));
            Console.WriteLine("Registered Successfully!");

            foreach (User user in UserCredentials)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", user.UserName, user.PassWord);
            }

        }
    }
}
