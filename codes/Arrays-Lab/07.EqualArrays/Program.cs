using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool equal = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currEl = arr1[i];

                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    equal = false;
                    break;
                }
                else
                {
                    sum += currEl;
                }

            }

            if (equal == true)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            

        }
    }
}
