using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char curCh = username[i];
                password += curCh;
            }

            int totalTries = 1;
            string enteredPass;
            while ((enteredPass = Console.ReadLine()) != password)
            {


                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                totalTries++;

            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
