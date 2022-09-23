using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int currDigit = num % 10;
                sum += currDigit;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
