using System;
using System.Diagnostics;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expences = 0;
            /* 
            int mouseTrash = 0;
            int headsetTrash = 0;
            int keyboardTrash = 0;
            int displayTrash = 0;

            for (int currCount = 1; currCount <= lostGamesCount; currCount++)
            {
                if (currCount % 2 == 0)
                {
                    headsetTrash++;

                }
                if (currCount % 3 == 0)
                {

                    mouseTrash++;

                }
                if (currCount % 2 == 0 && currCount % 3 == 0)
                {
                    keyboardTrash++;

                }
                if (currCount % 12 == 0)
                {
                    displayTrash++;

                }
                expences = (headsetTrash * headsetPrice) + (keyboardTrash * keyboardPrice) + (displayTrash * displayPrice) + (mouseTrash * mousePrice);

            }*/

            int headsetTrash = lostGamesCount / 2;
            int mouseTrash = lostGamesCount / 3;
            int keyboardTrash = lostGamesCount / 6;
            int displayTrash = lostGamesCount / 12;

            expences = (headsetTrash * headsetPrice) + (keyboardTrash * keyboardPrice) + (displayTrash * displayPrice) + (mouseTrash * mousePrice);
            Console.WriteLine($"Rage expenses: {expences:f2} lv.");

        }
    }
}
