using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\=|\/)?(?<dest>[A-Z][A-Za-z]{2,})(\1)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            List<string> desti = new List<string>();

            foreach (Match item in matches)
            {
                string currDest = item.Groups["dest"].Value;
                desti.Add(currDest);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", desti)}");

            int travelPoints = 0;

            foreach (Match mch in matches)
            {
                string currMch = mch.Groups["dest"].Value;
                travelPoints += currMch.Length;
            }

            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
