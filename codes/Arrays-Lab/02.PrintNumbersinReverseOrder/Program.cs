using System;

namespace _02.PrintNumbersinReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            

        }
    }
}
