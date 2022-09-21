using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                             
            int sumOfDigits = 0;
            bool condition = false;
            for (int i = 1; i <= n; i++)
            {
                int currDigit = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                condition = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", currDigit, condition);
                sumOfDigits = 0;
                i = currDigit;
            }

        }
    }
}
