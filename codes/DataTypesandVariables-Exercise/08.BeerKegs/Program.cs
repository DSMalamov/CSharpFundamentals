using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            double volume = 0;

            for (int i = 0; i < n; i++)
            {
                string name1 = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currVolume > volume)
                {
                    name = name1;
                    volume = currVolume;
                }
            }
            Console.WriteLine(name);
        }
    }
}
