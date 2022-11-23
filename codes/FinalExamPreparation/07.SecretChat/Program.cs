using System;
using System.Linq;

namespace _07.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] cmdArg = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArg[0];

                if (cmd == "InsertSpace")
                {
                    int index = int.Parse(cmdArg[1]);

                    input = input.Insert(index, " ");

                    Console.WriteLine(input);
                }
                else if (cmd == "Reverse")
                {
                    string substring = cmdArg[1];

                    if (input.Contains(substring))
                    {
                        int startIndex = input.IndexOf(substring);
                        input = input.Remove(startIndex, substring.Length);
                        input += string.Join("",substring.Reverse());

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, replacement);

                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
