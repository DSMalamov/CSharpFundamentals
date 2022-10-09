using System;

namespace _10.MultiplyEvensbyOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = Math.Abs(input);
            int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            Console.WriteLine(result);

        }

        static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;

            for (int i = 0; num > 0; i++)
            {
                int currNum = 0;
                currNum = num % 10;
                if (currNum % 2 != 0)
                {
                    oddSum += currNum;
                }
                num /= 10;
                
            }

            return oddSum;
        
        }
        static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;

            for (int i = 0; num > 0; i++)
            {
                int currNum = 0;
                currNum = num % 10;
                if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
                num /= 10;

            }

            return evenSum;

        }

    }
}
