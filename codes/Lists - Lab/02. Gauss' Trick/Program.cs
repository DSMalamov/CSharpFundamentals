using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();
            
            for (int i = 0; i < list.Count / 2; i++)
            {
                int currSum = list[i] + list[list.Count - 1 - i] ;
                result.Add(currSum);
                
            }

            if (list.Count % 2 != 0)
            {
                result.Add(list[list.Count / 2]);
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
