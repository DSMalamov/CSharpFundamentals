using System;
using System.Collections.Generic;

namespace _15.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command1;
            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
            //The list at index 0 = population and at index 1 = gold
            
            while ((command1 = Console.ReadLine()) != "Sail")
            {
                string[] cmdArg = command1
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = cmdArg[0];
                int population = int.Parse(cmdArg[1]);
                int gold = int.Parse(cmdArg[2]);

                if (!dic.ContainsKey(city))
                {
                    dic[city] = new List<int> { population, gold };
                }
                else
                {
                    dic[city][0] += population;
                    dic[city][1] += gold;
                }
                
            }

            string command2;

            while ((command2 = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command2
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];
                string city = cmdArg[1];

                if (cmdInfo == "Plunder")
                {
                    int population = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);

                    dic[city][0] -= population;
                    dic[city][1] -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (dic[city][0] <= 0 || dic[city][1] <= 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        dic.Remove(city);
                    }
                }
                else if (cmdInfo == "Prosper")
                {
                    int gold = int.Parse(cmdArg[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }

                    dic[city][1] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {dic[city][1]} gold.");

                }
            }

            if (dic.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dic.Count} wealthy settlements to go to:");
                foreach (var item in dic)
                {
                    Console.WriteLine($"{item.Key} -> Population: {dic[item.Key][0]} citizens, Gold: {dic[item.Key][1]} kg");
                }
                
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
    
    


    
    
}
