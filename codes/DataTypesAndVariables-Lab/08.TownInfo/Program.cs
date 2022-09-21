using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            ulong population = ulong.Parse(Console.ReadLine());
            long area = long.Parse(Console.ReadLine());
            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
