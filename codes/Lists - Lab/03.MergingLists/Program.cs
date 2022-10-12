using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> list2 = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int n = Math.Min(list1.Count, list2.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);

            }



            if (list1.Count > list2.Count)
            {
                for (int i = n; i < list1.Count; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else if (list1.Count < list2.Count)
            {
                for (int i = n; i < list2.Count; i++)
                {
                    result.Add(list2[i]);
                }

            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
