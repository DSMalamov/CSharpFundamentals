using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 0;

            for (int i = 0; i < n; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());
                if ((capacity + litersToAdd) <= 255)
                {
                    capacity += litersToAdd;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
