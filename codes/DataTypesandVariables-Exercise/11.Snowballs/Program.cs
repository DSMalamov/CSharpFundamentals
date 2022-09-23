
namespace _11.Snowballs
{
    using System;
    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger hightestValue = BigInteger.Zero;
            int snow1 = 0;
            int time1 = 0;
            int quality1 = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snow / time), quality);

                if (hightestValue < value)
                {
                    hightestValue = value;
                    snow1 = snow;
                    time1 = time;
                    quality1 = quality;
                }

            }

            Console.WriteLine($"{snow1} : {time1} = {hightestValue} ({quality1})");
        }
    }
}
