using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.Loops
{
    internal class UserAuthentication
    {
        /*
         * 4 Design a simple login system in C# where users provide their username and password. 
         * Use conditional statements to check the credentials and provide appropriate feedback, such as 
         * successful login, incorrect username, incorrect password, or account locked.
         */

        private const int MAX_ATTEMPTS = 3; 

        public static void userAuthentication()
        {
            string correctUsername = "admin";
            string correctPassword = "password123";
            int attempts = 0;
            bool isLocked = false;
            while (attempts < MAX_ATTEMPTS && !isLocked)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username != correctUsername)
                {
                    Console.WriteLine("Incorrect username.");
                }
                else if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password.");
                }
                else
                {
                    Console.WriteLine("Login successful!");
                    return;
                }

                attempts++;

                if (attempts >= MAX_ATTEMPTS)
                {
                    isLocked = true;
                    Console.WriteLine("Account locked due to too many failed attempts.");
                }
            }
        }
    }
}
