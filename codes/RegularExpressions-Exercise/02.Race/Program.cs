using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var racers = new Dictionary<string, int>();
                
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string patternName = @"(?<racer>[A-Za-z]+)";
            string patternDistance = @"(?<distance>[\d]+)";
            Regex regexName = new Regex(patternName);
            Regex regexDistance = new Regex(patternDistance);

            string command;

            while ((command = Console.ReadLine()) != "end of race")
            {
                MatchCollection match = regexName.Matches(command);
                MatchCollection match1 = regexDistance.Matches(command);
                
                StringBuilder name = new StringBuilder();
                StringBuilder distance = new StringBuilder();

                foreach (Match item in match)
                {
                    name.Append(item);
                }
                foreach (Match item1 in match1)
                {
                    distance.Append(item1);
                }

                if (input.Contains(name.ToString()))
                {
                    if (!racers.ContainsKey(name.ToString()))
                    {
                        racers.Add(name.ToString(), int.Parse(distance.ToString()));
                    }
                    else
                    {
                        racers[name.ToString()] += int.Parse(distance.ToString());
                    }
                }

            }

            var topThreePlayers = racers.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, y => y.Value);
            int counter = 0;

            foreach (var item in topThreePlayers)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
            }

        }
    }
}
