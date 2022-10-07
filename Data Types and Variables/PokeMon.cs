using System;

namespace PokeMon
{
    internal class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustFactor = int.Parse(Console.ReadLine());
            int pokedCount = 0;
            double fiftyPerc = power * 0.5;
            int powerCopy = power;

            while (powerCopy >= distance)
            {

                powerCopy -= distance;
                pokedCount++;

                if (powerCopy == fiftyPerc && exhaustFactor != 0)
                {

                    powerCopy /= exhaustFactor;

                }

            }
            Console.WriteLine(powerCopy);
            Console.WriteLine(pokedCount);

        }
    }
}
