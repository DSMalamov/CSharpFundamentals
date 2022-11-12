using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string file = input[input.Length - 1];

            string name = string.Empty;
            string extension = file.Substring(file.LastIndexOf('.') + 1);

            for (int i = 0; i < file.LastIndexOf('.'); i++)
            {
                name += file[i];
            }

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
