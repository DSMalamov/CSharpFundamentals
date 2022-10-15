using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(' ');

                if (cmdArg[0] == "Add")
                {
                    int newWagon = int.Parse(cmdArg[1]);
                    listOfWagons.Add(newWagon);
                }
                else
                {
                    int passangersToFit = int.Parse(cmdArg[0]);

                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        int currWagon = listOfWagons[i];
                        if (currWagon + passangersToFit <= capacity)
                        {
                            listOfWagons[i] += passangersToFit;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(" ", listOfWagons));
        }
    }
}
