using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);

            if (regex.IsMatch(input))
            {
                foreach (Match email in match)
                {
                    Console.WriteLine(email);
                }
            }



        }
    }
}
