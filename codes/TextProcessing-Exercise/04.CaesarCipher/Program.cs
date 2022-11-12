using System;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            foreach (var currCh in input)
            {
                int indexOfNewCh = currCh + 3;
                output += (char)indexOfNewCh;
            }

            Console.WriteLine(output);
        }
    }
}
