using System;

namespace BackIn30Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine()) + 30;   

            if(mins >= 60)
            {
                hours += 1;
                mins = mins - 60;

                if(hours > 23)
                {
                    hours = 0;
                }
                
            }
            Console.WriteLine($"{hours}:{mins:D2}");


        }
    }
}
