using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());

            int[] field = new int[sizeOfTheField];

            int[] initialIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
                
            }

            string command;
            while ((command = Console.ReadLine()) != "end" )
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(cmdArg[0]);
                string direction = cmdArg[1];
                int flyLength = int.Parse(cmdArg[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0 )
                {
                    continue;

                }

                field[ladyBugIndex] = 0;
                if (direction == "left")
                {
                    flyLength *= -1;
                }

                int nextIndex = ladyBugIndex + flyLength;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;

                }

                if (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 0)
                {
                    field[nextIndex] = 1;
                }
               
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
