﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Huntt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            List<string> steal = new List<string>();

            double totalSum = 0;

            string input = Console.ReadLine();



            while (input != "Yohoho!")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Loot":
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (!chest.Contains(command[i]))
                            {
                                chest.Insert(0, command[i]);
                            }
                        }
                        break;

                    case "Drop":
                        int dropIndex = int.Parse(command[1]);

                        if (dropIndex >= 0 && dropIndex < chest.Count)

                        {
                            string currItem = chest[dropIndex];
                            chest.RemoveAt(dropIndex);
                            chest.Add(currItem);
                        }
                        break;

                    case "Steal":

                        int count = int.Parse(command[1]);


                        if (count < chest.Count)
                        {

                            for (int i = chest.Count - count; i < chest.Count; i++)
                            {
                                steal.Add(chest[i]);
                            }
                            Console.WriteLine(string.Join(", ", steal));
                            steal.Clear();

                            chest.RemoveRange(chest.Count - count, count);

                        }

                        else
                        {

                            for (int i = 0; i < chest.Count; i++)
                            {
                                steal.Add(chest[i]);
                            }

                            Console.WriteLine(string.Join(", ", steal));

                            steal.Clear();

                            chest.RemoveRange(0, chest.Count);

                        }


                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (chest.Count != 0)
            {
                double sum = 0;
                int counter = 0;

                for (int i = 0; i < chest.Count; i++)
                {
                    sum += chest[i].Length;
                    counter++;
                }

                totalSum = sum / counter;

                Console.WriteLine($"Average treasure gain: {totalSum:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
