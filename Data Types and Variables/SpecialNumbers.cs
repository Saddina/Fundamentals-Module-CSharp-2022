using System;

namespace SpecialNumbers
{
    internal class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int iCopy = i;
                int sum = 0;

                while (iCopy > 0)
                {
                    sum += iCopy % 10;
                    iCopy /= 10;
                }


                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
        }
    }
}

