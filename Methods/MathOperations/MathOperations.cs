using System;

namespace MathOperations
{
    internal class MathOperations
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculation(firstNum, @operator, secondNum);
            Console.WriteLine(result);


        }

        static double Calculation(int firstNum, string @operator, int secondNum)
        {
            double result = 0;

            switch (@operator)
            {
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
                case "/": result = firstNum / secondNum; break;
                case "*": result = firstNum * secondNum; break;
            }
            return result;
        }
    }
}
