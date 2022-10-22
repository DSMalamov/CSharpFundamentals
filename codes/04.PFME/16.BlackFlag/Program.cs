using System;

namespace _16.BlackFlag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dayliPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double currentPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                currentPlunder += dayliPlunder;

                if (i % 3 == 0)
                {
                    currentPlunder += dayliPlunder * 0.5;
                }

                if (i % 5 == 0)
                {
                    currentPlunder *= 0.7;
                }

            }

            if (currentPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {currentPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = currentPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
