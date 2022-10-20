using System;
using System.Linq;

namespace VowelsCount
{
    internal class VowelsCount
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelCount = GetVowelsCount(text);
            Console.WriteLine(vowelCount);
        }

        static int GetVowelsCount(string text)
        {
            int vowelCount = 0;

            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };

            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
