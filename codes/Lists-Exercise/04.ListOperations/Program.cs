using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "Add":
                        input.Add(int.Parse(cmdArgs[1]));
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(cmdArgs[1]);
                        int index = int.Parse(cmdArgs[2]);

                        if (index < 0 || index > input.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        input.Insert(index, numberToInsert);

                        break;

                    case "Remove":
                        int index1 = int.Parse(cmdArgs[1]);
                        if (index1 < 0 || index1 > input.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }

                        input.RemoveAt(index1);

                        break;
                    case "Shift":
                        string direction = cmdArgs[1];
                        int count = int.Parse(cmdArgs[2]);

                        if (direction == "left")
                        {
                            ShiftNumberToLeft(input, count);
                        }
                        else
                        {
                            ShiftNumbersToRight(input, count);
                        }
                        break;     
                }

            }
            Console.WriteLine(String.Join(" ", input));


        }
        static void ShiftNumberToLeft (List<int> input , int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = input[0];
                input.RemoveAt(0);
                input.Add(currNum);
            }

        }
        static void ShiftNumbersToRight (List<int> input, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = input[input.Count - 1];
                input.RemoveAt(input.Count - 1);
                input.Insert(0, currNum);
            }

        }
       
    }
}
