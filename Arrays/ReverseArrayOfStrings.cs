using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {

            string[] word = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i] + " ");
            }
        }
    }
}
