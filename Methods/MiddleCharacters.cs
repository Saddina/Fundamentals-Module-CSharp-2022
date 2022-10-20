using System;

namespace MiddleCharacters
{
    internal class MiddleCharacters
    {
        static void Main(string[] args)
        {
            string strng = Console.ReadLine();

            Console.WriteLine(GetMiddleCh(strng));
        }

        static string GetMiddleCh(string strng)
        {
            int middle;
            string res = "";

            if (strng.Length % 2 == 0)
            {
                middle = 1 - strng.Length % 2;
                res = strng.Substring
                    (strng.Length / 2 - middle, 1 + middle).ToString();
            }
            else
            {
                res = strng[strng.Length / 2].ToString();

            }
            return res;
        }
    }
}
