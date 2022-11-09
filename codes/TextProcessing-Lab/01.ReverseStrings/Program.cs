using System;

namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string reversedCmd = string.Empty;

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reversedCmd += command[i];
                }

                Console.WriteLine($"{command} = {reversedCmd}");
            }

            
        }

    }
}
