using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] cmdArg = comand
                    .Split();

                switch (cmdArg[0])
                {
                    case "Add":
                        int addedNumber = int.Parse(cmdArg[1]);
                        input.Add(addedNumber);
                        break;
                    case "Remove":
                        int removedNumber = int.Parse(cmdArg[1]);
                        input.Remove(removedNumber);
                        break;
                    case "RemoveAt":
                        int removedAt = int.Parse(cmdArg[1]);
                        input.RemoveAt(removedAt);
                        break;
                    case "Insert":
                        int number = int.Parse(cmdArg[1]);
                        int index = int.Parse(cmdArg[2]);
                        input.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", input));


        }
    }
}
