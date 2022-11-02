using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var occ = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string wordLower = word.ToLower();

                if (!occ.ContainsKey(wordLower))
                {
                    occ.Add(wordLower, 0);
                }

                occ[wordLower]++;
            }

            foreach (var item in occ)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }



        }
    }
}
