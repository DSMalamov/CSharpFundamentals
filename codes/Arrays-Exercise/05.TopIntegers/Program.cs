using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int currNum1 = array[i];
                int currNum2 = int.MinValue;
                for (int j = i + 1; j < array.Length; j++)
                {
                    currNum2 = array[j];

                    if (currNum1 <= currNum2)
                    {
                        break;
                    }
                   
                }
                if (currNum1 > currNum2)
                {
                    Console.Write(String.Join(" ", currNum1 + " "));
                }

                
                
            }
        }
    }
}
