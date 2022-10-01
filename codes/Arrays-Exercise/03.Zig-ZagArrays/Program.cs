using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] s = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstN = s[0];
                int secondN = s[1];

                if (i % 2 == 0)
                {
                    first[i-1] = secondN;
                    second[i-1] = firstN;
                }
                else
                {
                    first[i-1] = firstN;
                    second[i-1] = secondN;
                }
            }

            Console.WriteLine(String.Join(" ", first));
            Console.WriteLine(String.Join(" ", second));
        }
    }
}
