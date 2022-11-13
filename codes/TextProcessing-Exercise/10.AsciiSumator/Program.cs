using System;

namespace _10.AsciiSumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar > firstChar && currChar < secondChar) 
                {
                    sum += currChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
