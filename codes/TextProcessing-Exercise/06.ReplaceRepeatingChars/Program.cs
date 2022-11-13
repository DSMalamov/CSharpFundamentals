using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char save = input[0];
            Console.Write(save);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != save)
                {
                    Console.Write(input[i]);
                    save = input[i];
                }
            }
        }
    }
}
