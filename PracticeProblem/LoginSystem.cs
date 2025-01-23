using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class LoginSystem
    {
        public static void LoginPage()
        {
            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();


            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();


            if (username != "Vaibhav")
            {
                Console.WriteLine("Invalid username Please enter valid username");
            }
            else if (password != "Vaibhav@123")
            {
                Console.WriteLine("Invalid password Please enter valid password");
            }
            else if (username == "Vaibhav" && password == "Vaibhav@123")
            {
                Console.WriteLine("Successful Login ");
            }
        }
    }
}
