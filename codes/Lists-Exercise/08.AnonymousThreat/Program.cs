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
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);

                    
                    string indexCopy = input[index];
                    List<string> partitionsList = DivideWord(indexCopy, partitions);

                    input.RemoveAt(index);
                    input.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static List<string> DivideWord(string indexCopy, int partitions)
        {
            
            int partitionLength = indexCopy.Length / partitions;
            int lastPartLength = indexCopy.Length - partitionLength * (partitions - 1);

            List<string> partitionsList = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = partitionLength;
                
                if (i == partitions - 1)
                {
                    desiredLength = lastPartLength;
                }


                char[] newpartitionArray = indexCopy
                    .Skip(i * partitionLength)
                    .Take(desiredLength)
                    .ToArray();

                string partitionJoin = String.Join("", newpartitionArray);
                partitionsList.Add(partitionJoin);
                    
                
            }

            return partitionsList;
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
