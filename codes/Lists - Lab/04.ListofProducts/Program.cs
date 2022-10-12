using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListofProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currInput = Console.ReadLine();
                list.Add(currInput);
            }

            list.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }

        }
    }
}
