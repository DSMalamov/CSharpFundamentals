using System;

namespace _16.DecryptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];

                if (cmdInfo == "Replace")
                {
                    string currChar = cmdArg[1];
                    string newChar = cmdArg[2];

                    if (input.Contains(currChar))
                    {
                        input = input.Replace(currChar, newChar);

                        Console.WriteLine(input);
                    }
                    
                }
                else if (cmdInfo == "Make")
                {
                    if (cmdArg[1] == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    else if (cmdArg[1] == "Lower")
                    {
                        input = input.ToLower();
                    }

                    Console.WriteLine(input);
                }
                else if (cmdInfo == "Cut")
                {
                    int start = int.Parse(cmdArg[1]);
                    int end = int.Parse(cmdArg[2]);

                    if ((start >= 0 && start < input.Length) && (end >= 0 && end < input.Length) && start <= end)
                    {
                        input = input.Remove(start , end - start + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
                else if (cmdInfo == "Check")
                {
                    string substring = cmdArg[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (cmdInfo == "Sum")
                {
                    int start = int.Parse(cmdArg[1]);
                    int end = int.Parse(cmdArg[2]);
                    
                    if (start < 0 || start > input.Length || end < 0 || end > input.Length)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        string substring = input.Substring(start, end - start + 1);
                        int sum = 0;

                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += substring[i];
                        }

                        Console.WriteLine(sum);
                    }
                }
            }

        }
    }
}
