using System;

namespace PalindromeIntegers
{
    internal class PalindromeIntegers
    {
        static void Main(string[] args)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                int n = cmd.Length;

                IsPalindrome(cmd, n);
            }

            if (cmd == "END")
            {
                return;
            }
        }

        static void IsPalindrome(string cmd, int n)
        {
            int flag = 0;
            for (int i = 0; i <= n / 2 && n != 0; i++)
            {
                if (cmd[i] != cmd[n - i - 1])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("false");

            }
            else
            {
                Console.WriteLine("true");
            }

        }
    }
}

