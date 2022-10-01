using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {

                for (int r = i + 1; r < array.Length; r++)
                {

                    int currRightNum = array[r];
                    rightSum += currRightNum;
                }
                for (int l = i - 1; l >= 0; l--)
                {
                    int currLeftNum = array[l];
                    leftSum += currLeftNum;
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    counter++;
                }
                leftSum = 0;
                rightSum = 0;
                
            }
            if (counter == 0)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
