﻿using System;

namespace SumOfChars
{
    internal class SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char currCh = char.Parse(Console.ReadLine());

                sum += (int)currCh;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
