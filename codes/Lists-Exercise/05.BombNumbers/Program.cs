using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            while (input.Contains(command[0]))
            {
                int power = command[1];

                for (int i = 0; i < input.Count; i++)
                {
                    int currNum = input[i];
                    int startingIndex = 0;
                    int finalIndex = 0;
                    int totalPower = 2 * power + 1;

                    if (currNum == command[0])
                    {
                        if (i - power < 0)
                        {
                            startingIndex = 0;
                        }
                        else
                        {
                            startingIndex = i - power;
                        }

                        if (i + power > input.Count - 1)
                        {
                            finalIndex = input.Count - 1;
                        }
                        else
                        {
                            finalIndex = i + power;
                        }

                        for (int j = startingIndex; j <= finalIndex; j++)
                        {
                            input.RemoveAt(startingIndex);
                        }



                    }
                }
            }

            Console.WriteLine(input.Sum());
                



        }
    }
}
