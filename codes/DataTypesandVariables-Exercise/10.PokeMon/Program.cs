using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokes = 0;
            int powerCopy = pokePower;
            while (distance <= pokePower)
            {
                pokePower -= distance;
                pokes++;
                if (pokePower == (powerCopy/2))
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }


            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokes);
        }
    }
}
