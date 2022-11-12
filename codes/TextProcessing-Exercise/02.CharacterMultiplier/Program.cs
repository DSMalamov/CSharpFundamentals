using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');
            CodeMultiplication(input[0], input[1]);
        }

        private static void CodeMultiplication(string name1, string name2)
        {
            int sum = 0;
            string longestName = string.Empty;
            string shortestName = string.Empty;

            if (name1.Length >= name2.Length)
            {
                longestName = name1;
                shortestName = name2;
            }
            else
            {
                longestName = name2;
                shortestName = name1;
            }

            for (int i = 0; i < shortestName.Length; i++)
            {
                sum += (int)longestName[i] * shortestName[i];
            }

            for (int i = shortestName.Length; i < longestName.Length; i++)
            {
                sum += (int)longestName[i];
            }

            Console.WriteLine(sum);

        }
    }
}
