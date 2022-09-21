using System;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal curN = decimal.Parse(Console.ReadLine());
                totalSum += curN;
            }
            Console.WriteLine(totalSum);
        }
    }
}
