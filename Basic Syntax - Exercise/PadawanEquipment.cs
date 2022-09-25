using System;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int studCount = int.Parse(Console.ReadLine());
            double lsSinglePrice = double.Parse(Console.ReadLine());
            double robeSinglePrice = double.Parse(Console.ReadLine());
            double beltSinglePrice = double.Parse(Console.ReadLine());

            int freeBeltCount = 0;
            for (int i = 1; i <= studCount; i++)
            {
                if (i % 6 == 0)
                {
                    freeBeltCount += 1;
                }
            }

            double expences = (lsSinglePrice * (studCount + (Math.Ceiling(studCount * 0.10)))) + (robeSinglePrice * studCount) + (beltSinglePrice * (studCount - freeBeltCount));

            double diff = Math.Abs(moneyAmount - expences);
            if (expences <= moneyAmount)
            {
                Console.WriteLine($"The money is enough - it would cost {expences:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}
