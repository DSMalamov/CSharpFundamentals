using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string output = RepeatedString(input, n);
            Console.WriteLine(output);
        }
        static string RepeatedString(string input, int n)
        {
            string output = "";

            for (int i = 0; i < n; i++)
            {
                output += input;
            }
            return output;
        }
    }
}
