using System;

namespace MySharedLibrary
{
    public class Utilities
    {

        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            return name.Length >= 3;
        }

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasUpperCase && hasLowerCase && hasDigit)
                    break;
            }

            return password.Length >= 8 && hasUpperCase && hasLowerCase && hasDigit;
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
        public static string EncryptPassword(string password)
        {

            return password;
        }
    }
}