using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int curNum = i;
                int sumOfDigits = 0;

                while (curNum > 0)
                {
                    int currDigit = curNum % 10;
                    sumOfDigits += currDigit;
                    curNum /= 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                
                sumOfDigits = 0;
            }
        }
    }
}
