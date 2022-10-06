using System;

namespace Data_Types_And_Variables
{
    internal class MetersToKilometers
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            float kms = meters / 1000.0f;

            Console.WriteLine($"{kms:f2}");
        }
    }
}
