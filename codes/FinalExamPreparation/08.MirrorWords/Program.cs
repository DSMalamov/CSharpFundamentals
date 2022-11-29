using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\@|\#){1}(?<word>[A-Za-z]{3,}(\1){2}[A-Za-z]{3,})(\1)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            List<string> mirrorPairs = new List<string>();

            foreach (Match match in matches)
            {
                string currMatch = match.Groups["word"].Value;
                string word1 = currMatch.Substring(0, currMatch.Length / 2  - 1);
                string word2 = currMatch.Substring(currMatch.Length / 2 + 1, word1.Length);
                string reversed = string.Empty;

                for (int i = word2.Length - 1; i >= 0; i--)
                {
                    reversed += word2[i];
                }
                

                string[] currPair = new string[] { word1, word2 };

                if (word1 == reversed)
                {
                    mirrorPairs.Add(string.Join(" <=> ", currPair));
                }
                
            }

            if (mirrorPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", mirrorPairs));
            }
            
        }
    }
}
