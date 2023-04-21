using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Authorization
{
    internal class Authorization
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Registration");

            // Type your new username and press enter
            Console.WriteLine("Enter new username:");

            // Create a string variable and get user input
            string userName = Console.ReadLine();

            // Type your new password and press enter
            Console.WriteLine("Enter new password:");

            // Create a string variable and get password
            string userPass = Console.ReadLine();


            for (int i = 1; i < 7; i++)
            {
                if (i == 6)
                {
                    Console.WriteLine("The password or name you’ve entered is incorrect.");
                    break;
                }

                Console.WriteLine("Log in ");

                // Type your username and press enter
                Console.WriteLine("Enter your username:");

                // Create a string variable and get user input
                string newName = Console.ReadLine();

                // Type your password and press enter
                Console.WriteLine("Enter your password:");

                //Create a string variable and get password
                string newPass = Console.ReadLine();
                if (userName == newName && userPass == newPass)
                {
                    Console.WriteLine("Authorization completed successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again...");
                }

            }

             
            }
    }
}
