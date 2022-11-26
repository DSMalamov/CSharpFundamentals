using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _14.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger coolThreshold = 1;
            coolThreshold = CoolThreshold(input, coolThreshold);
            Console.WriteLine($"Cool threshold: {coolThreshold}");

            string pattern = @"((\:\:)|(\*\*))(?<emoji>[A-Z][a-z]{2,})(\1)";

            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(input);
            Console.WriteLine($"{match.Count} emojis found in the text. The cool ones are:");

            foreach (Match item in match)
            {
                string emoji = item.ToString();
                string emojiValue = item.Groups["emoji"].Value;
                BigInteger coolness = 0;

                foreach (var ch in emojiValue)
                {
                    coolness += (int)ch;

                }

                if (coolness >= coolThreshold)
                {
                    Console.WriteLine(emoji );
                }
            }

        }

        private static BigInteger CoolThreshold(string input, BigInteger coolThreshold)
        {
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    coolThreshold *= (int)ch - 48;
                }
            }

            return coolThreshold;
        }
    }
}
