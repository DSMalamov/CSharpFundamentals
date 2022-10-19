using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double average = input.Average();

            List<int> output = new List<int>();

            input.Sort();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                
                if (output.Count < 5)
                {
                    if (input[i] > average)
                    {
                        output.Add(input[i]);
                    }
                }
            }

            if (output.Count > 0)
            {
                
                Console.WriteLine(String.Join(" ", output));
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }
}
