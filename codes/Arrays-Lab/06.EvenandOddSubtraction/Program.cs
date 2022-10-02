using System;
using System.Linq;

namespace _06.EvenandOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];

                if (currNum % 2 == 0)
                {
                    evenSum += currNum;
                }
                else
                {
                    oddSum += currNum;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
