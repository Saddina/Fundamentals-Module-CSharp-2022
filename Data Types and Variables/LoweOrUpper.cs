using System;

namespace LoweOrUpper
{
    internal class LoweOrUpper
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (Char.IsLower(ch))
            {
                Console.WriteLine("lower-case");
            }
            else if (Char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
