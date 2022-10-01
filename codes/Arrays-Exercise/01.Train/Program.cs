using System;
using System.Linq;

namespace _01.Train
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] numberOfWagons = new int[wagons];
            int sum = 0;
            for (int i = 0; i <= wagons - 1; i++)
            {
                int passangersInCurrnetWagon = int.Parse(Console.ReadLine());
                numberOfWagons[i] = passangersInCurrnetWagon;
                sum += passangersInCurrnetWagon;
                
            }
            Console.WriteLine(string.Join(" ", numberOfWagons));
            Console.WriteLine(sum);

        }
    }
}
