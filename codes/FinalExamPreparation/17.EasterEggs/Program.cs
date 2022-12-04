using System;
using System.Text.RegularExpressions;

namespace _17.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"[\@|\#]+(?<color>[a-z]{3,})[\@|\#]+[^[A-Za-z0-9]*[\/]+(?<amount>[0-9]+)[\/]+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                string color = item.Groups["color"].Value;
                int amount = int.Parse(item.Groups["amount"].Value);

                Console.WriteLine($"You found {amount} {color} eggs!");
            }

        }
    }
}
