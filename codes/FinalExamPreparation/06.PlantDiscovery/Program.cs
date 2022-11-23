using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plantRarity = new Dictionary<string, int>();
            var plantRating = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (!plantRarity.ContainsKey(plant))
                {
                    plantRarity.Add(plant, rarity);
                    plantRating.Add(plant, new List<double>());
                }
                else
                {
                    plantRarity[plant] = rarity;
                }

            }

            string command;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArg = command
                    .Split(new char[] { ' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);

                string plant = cmdArg[1];
                
                if (cmdArg[0] == "Rate")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Add(double.Parse(cmdArg[2]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdArg[0] == "Update")
                {
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant] = int.Parse(cmdArg[2]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdArg[0] == "Reset")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plantRarity)
            {
                if (plantRating[item.Key].Count > 0)
                {
                    double avarage = plantRating[item.Key].Average();
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {avarage:f2}");
                }
                else
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {0:f2}");
                }
                
               
            }
        }
    }
}
