using System;
using System.Linq;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int currNum1 = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    int currNum2 = array[j];
                    if (currNum1 + currNum2 == magicNum)
                    {
                        Console.WriteLine($"{currNum1} {currNum2}");
                    }
                }
            }
        }
    }
}
