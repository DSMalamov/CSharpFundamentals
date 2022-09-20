using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int num = 0;
            int totalSum = 0;
            int currNum = 1;
            while (number > 0)
            {
                num = number % 10;
                number /= 10;
                for (int i = 1; i <= num; i++)
                {
                    currNum *= i;
                    
                }

                totalSum += currNum;
                currNum = 1;
            }

            if (totalSum == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
