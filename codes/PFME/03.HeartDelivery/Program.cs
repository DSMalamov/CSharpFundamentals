using System;
using System.Linq;

namespace _03.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int lastPosition = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int jumpLegth = int.Parse(cmdArg[1]);

                if (jumpLegth + lastPosition >= neighborhood.Length)
                {
                    lastPosition = 0;
                }
                else
                {
                    lastPosition += jumpLegth;
                }

                if (neighborhood[lastPosition] != 0)
                {
                    neighborhood[lastPosition] -= 2;

                    if (neighborhood[lastPosition] == 0)
                    {
                        Console.WriteLine($"Place {lastPosition} has Valentine's day." );
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            if (neighborhood.Length == count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - count} places.");
            }

        }
    }
}
