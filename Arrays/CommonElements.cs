using System;
using System.Linq;

namespace CommonElements
{
    internal class CommonElements
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string[] array2 = Console.ReadLine()
                .Split(" ")
                .ToArray();
            string commonEl = "";

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        commonEl = array2[j];
                        string[] common = { commonEl + " " };
                        Console.Write(String.Join(" ", common));
                    }
                }
            }


        }

    }
}
