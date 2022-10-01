using System;
using System.Linq;

namespace _07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int counter = 0;
            int max = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                
                if (array[i] == array[i + 1])
                {
                    counter++;
                   
                    if (counter > max)
                    {
                        max = counter;
                        start = i - counter;
                    }
                    
                }
                else
                {
                    counter = 0;
                }
            }
            for (int j = start + 1; j <= start + max + 1 ; j++)
            {
                Console.Write(array[j] + " ");
            }
        }
    }
}
