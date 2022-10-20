using System;

namespace PasswordValidator
{
    internal class PasswordValidator
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            bool isPassLengthValid = IsLengthValid(pass);
            bool isPassAlphaNum = IsPassAlphaNumeric(pass);
            bool atLeastTwoDigits = DoesPassContainsAtLeastTwoDigits(pass);

            if (!isPassLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassAlphaNum)
            {
                Console.WriteLine("Password must consist only of letters and digits");

            }
            if (!atLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPassLengthValid && isPassAlphaNum && atLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLengthValid(string pass)
        {
            bool isValid = pass.Length >= 6 && pass.Length <= 10;
            return isValid;
        }

        static bool IsPassAlphaNumeric(string pass)
        {
            foreach (char ch in pass)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }

            }
            return true;
        }

        static bool DoesPassContainsAtLeastTwoDigits(string pass)
        {
            int count = 0;

            foreach (char ch in pass)
            {
                if (Char.IsDigit(ch))
                {
                    count++;
                }
            }
            return count >= 2;
        }
    }
}
