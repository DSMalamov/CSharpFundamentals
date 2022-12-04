using System;
using System.Collections.Generic;

namespace _17._DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestMeals = new Dictionary<string, List<string>>();

            string command;
            int unlikedMeals = 0;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];
                string guest = cmdArg[1];
                string meal = cmdArg[2];
                
                if (cmdInfo == "Like")
                {
                    if (!guestMeals.ContainsKey(guest))
                    {
                        guestMeals[guest] = new List<string>();
                       
                    }

                    if (!guestMeals[guest].Contains(meal))
                    {
                        guestMeals[guest].Add(meal);
                    }
                }
                else if (cmdInfo == "Dislike")
                {
                    if (guestMeals.ContainsKey(guest))
                    {
                        if (guestMeals[guest].Contains(meal))
                        {
                            guestMeals[guest].Remove(meal);
                            unlikedMeals++;
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
            }

            foreach (var kvp in guestMeals)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
