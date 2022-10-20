using System;

namespace CharactersInRange
{
    internal class CharactersInRange
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            GetAllELBetweenTwoChars(first, second);
        }

        static void GetAllELBetweenTwoChars(char first, char second)
        {


            if (first > second)
            {
                (first, second) = (second, first);
            }

            for (int i = first + 1; i < second; i++)
            {

                Console.Write((char)i + " ");
            }

        }
    }
}
