using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < rotations; i++)
            {
                int firstindex = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    int currNumber = array[j];
                    array[j - 1] = currNumber;
                }
                array[array.Length - 1] = firstindex;
            }
            Console.WriteLine(String.Join(" ", array));

        }
    }
}
