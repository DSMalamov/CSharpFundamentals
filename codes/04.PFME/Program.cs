using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.MovingTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(' ');

                if (cmdArg[0] == "Shoot")
                {
                    int index = int.Parse(cmdArg[1]);
                    int power = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < input.Count)
                    {
                        input[index] -= power;
                        if (input[index] <= 0)
                        {
                            input.RemoveAt(index);
                        }
                    }
                }

                if (cmdArg[0] == "Add")
                {
                    int index = int.Parse(cmdArg[1]);
                    int value = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < input.Count)
                    {
                        input.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                if (cmdArg[0] == "Strike")
                {
                    int index = int.Parse(cmdArg[1]);
                    int radius = int.Parse(cmdArg[2]);

                    if (index - radius >= 0 && index + radius < input.Count)
                    {
                        input.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(String.Join("|", input));

        }
    }
}
