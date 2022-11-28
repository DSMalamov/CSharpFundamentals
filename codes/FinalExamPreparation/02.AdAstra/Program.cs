using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||\#)(?<name>[A-Za-z]+( [A-Za-z]+)?)(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<cal>\d{1,10000})(\1)";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            int totalCal = 0;
            foreach (Match cal in matches)
            {
                int calories = int.Parse(cal.Groups["cal"].Value);
                totalCal += calories;
            }

            int days = totalCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match item in matches)
            {
                string name = item.Groups["name"].Value;
                string date = item.Groups["date"].Value;
                int cal = int.Parse(item.Groups["cal"].Value);

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {cal}");

            }
        }
    }
}
