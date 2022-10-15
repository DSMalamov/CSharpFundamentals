using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Delete")
                {
                    int element = int.Parse(cmdArg[1]);
                    input.RemoveAll(x => x == element);
                }
                else if (cmdArg[0] == "Insert")
                {
                    int elementToInsert = int.Parse(cmdArg[1]);
                    int position = int.Parse(cmdArg[2]);

                    input.Insert(position, elementToInsert);

                }
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
