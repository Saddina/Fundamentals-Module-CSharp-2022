using System;

namespace RefactorSpecialNumbers
{
    internal class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            bool isSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int iCopy = i;
                while (iCopy > 0)
                {
                    sum += iCopy % 10;
                    iCopy /= 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);

            }

        }
    }
}
