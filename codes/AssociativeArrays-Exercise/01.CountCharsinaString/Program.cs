using System;
using System.Collections.Generic;

namespace _01.CountCharsinaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charOcc = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!charOcc.ContainsKey(ch))
                    {
                        charOcc[ch] = 0;

                    }
                    charOcc[ch]++;
                }
            }

            foreach (var item in charOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
