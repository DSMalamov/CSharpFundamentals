using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] cmdArg = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Collect")
                {
                    if (input.Contains(cmdArg[1]))
                    {
                        continue;
                    }
                    else
                    {
                        input.Add(cmdArg[1]);
                    }
                }
                else if (cmdArg[0] == "Drop")
                {
                    if (input.Contains(cmdArg[1]))
                    {
                        input.Remove(cmdArg[1]);
                    }
                }
                else if (cmdArg[0] == "Combine Items")
                {
                    string[] combineArray = cmdArg[1]
                        .Split(':', StringSplitOptions.RemoveEmptyEntries);

                    if (input.Contains(combineArray[0]))
                    {
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == combineArray[0])
                            {
                                input.Insert(i + 1, combineArray[1]);
                            }
                        }
                    }
                }
                else if (cmdArg[0] == "Renew")
                {

                    if (input.Contains(cmdArg[1]))
                    {
                        input.Remove(cmdArg[1]);
                        input.Add(cmdArg[1]);
                    }
                }


            }

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
