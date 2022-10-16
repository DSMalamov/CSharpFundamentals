using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "merge")
                {
                    MergeCommand(input, cmdArg);
                }
                else if (cmdArg[0] == "divide")
                {
                    DivideCommand(input, cmdArg);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

        private static void DivideCommand(List<string> input, string[] cmdArg)
        {
            int index = int.Parse(cmdArg[1]);
            int partitions = int.Parse(cmdArg[2]);

            int partitionLength = input[index].Length / partitions;
            int lastPartLength = input[index].Length - partitionLength * partitions;

            if (lastPartLength < partitionLength && lastPartLength != 0)
            {
                partitionLength -= 1;
                //lastPartLength = input[index].Length - partitionLength * partitions;
            }

            string indexCopy = input[index];
            input[index] = string.Empty;
            int counter = 0;
            int partitionCounter = 1;

            for (int i = 0; i < indexCopy.Length; i++)
            {
                char currEl = indexCopy[i];
                counter++;
                if (counter > partitionLength)
                {
                    counter = 1;
                    if (partitionCounter >= partitions)
                    {
                        
                    }
                    else
                    {
                        index++;
                        partitionCounter++;
                        input.Add("");
                    }
                    

                }

                input[index] += currEl;
            }
        }

        private static void MergeCommand(List<string> input, string[] cmdArg)
        {
            int startingIndex = int.Parse(cmdArg[1]);
            int endingIndex = int.Parse(cmdArg[2]);

            if (startingIndex < 0)
            {
                startingIndex = 0;
            }

            if (endingIndex > input.Count - 1)
            {
                endingIndex = input.Count - 1;
            }


            for (int i = startingIndex + 1; i <= endingIndex; i++)
            {
                string currEl = input[i];
                input[startingIndex] += currEl;

            }
            for (int i = startingIndex + 1; i <= endingIndex; i++)
            {
                input.RemoveAt(startingIndex + 1);
            }
        }
    }
}
