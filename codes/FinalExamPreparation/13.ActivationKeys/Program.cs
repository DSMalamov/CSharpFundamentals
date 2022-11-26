using System;

namespace _13.ActivationKeys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] cmdArg = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string commandInfo = cmdArg[0];

                if (commandInfo == "Contains")
                {
                    string substring = cmdArg[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (commandInfo == "Flip")
                {
                    string letterCase = cmdArg[1];
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);

                    if (letterCase == "Upper")
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                        input = input.Remove(startIndex, endIndex - startIndex);
                        input = input.Insert(startIndex, substring);

                    }
                    else if (letterCase == "Lower")
                    {
                        string substring = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        input = input.Remove(startIndex, endIndex - startIndex);
                        input = input.Insert(startIndex, substring);
                    }

                    Console.WriteLine(input);
                    
                }
                else if (commandInfo == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    input= input.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(input);
                }
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
