using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter User Name");
            string str=Console.ReadLine();

            if (Utilities.IsValidName(str))
            {
                Console.WriteLine($"{str} is a valid name.");
            }
            else
            {
                Console.WriteLine($"{str} is not a valid name.");
            }
            Console.WriteLine("Enter Passwrd");
            Console.WriteLine("password should contain one upper case lowers case and digit");

            string password = Console.ReadLine();
            if (Utilities.IsValidPassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is not valid.");
            }
        }
    }
}
