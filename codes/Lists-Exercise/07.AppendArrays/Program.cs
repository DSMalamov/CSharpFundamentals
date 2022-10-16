using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split('|').Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                string[] currEl = list[0]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                list.Add(String.Join(" ", currEl));
                list.RemoveAt(0);

            }

            Console.WriteLine(String.Join(" ", list));
            
            

        }
    }
}
