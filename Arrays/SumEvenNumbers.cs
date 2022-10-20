using System;
using System.Linq;

namespace SumEvenNumbers
{
    internal class SumEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
// s foreach
/* int[] evenNumbers = new int[4];
int index = 0;
 foreach(var item in numbers)
 * {
 * if(item % 2 == 0){
 * evenNumbers[index]++;
 * }
 * index++;
 * }
*/