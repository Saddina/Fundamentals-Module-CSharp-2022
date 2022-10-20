using System;

namespace RepeatString
{
    internal class RepeatString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatStrng(input, n);

            Console.WriteLine(result);
        }

        private static string RepeatStrng(string input, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
