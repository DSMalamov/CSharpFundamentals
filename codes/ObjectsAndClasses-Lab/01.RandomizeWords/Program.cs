using System;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ");

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                int randomIndex = random.Next(0, input.Length);
                string nextWord = input[randomIndex];

                input[i] = nextWord;
                input[randomIndex] = currWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }

    }
}
