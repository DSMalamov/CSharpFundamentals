using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currNum = array[i];

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
