using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequence = int.Parse(Console.ReadLine());

            int[] save = new int[sequence];
            int start = sequence - 1;
            int sum = 0;
            int max = 0;
            int bestSample = 0;
            int sample = 0;

            string check;

            while ((check = Console.ReadLine()) != "Clone them!")
            {
                int[] input = check
                    .Split("!")
                    .Select(int.Parse)
                    .ToArray();

                //Namirane i zapazvane na maksimalna duljina i nachalo na porednost.
                sample++;
                int currCount = 0;
                int currStart = 0;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] == 1 && input[i] == input[i + 1])
                    {

                        currStart = i - currCount;
                        currCount++;
                    }

                }
                int currSum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == 1)
                    {
                        currSum++;
                    }
                }
                
                if (max <= currCount)
                {
                    if (currCount > max)
                    {
                        start = currStart;
                        max = currCount;
                        save = input;
                        bestSample = sample;
                        sum = currSum;
                        continue;
                    }
                    
                    if (max == currCount && start >= currStart)
                    {
                        if (start > currStart)
                        {
                            start = currStart;
                            save = input;
                            bestSample = sample;
                            sum = currSum;
                            continue;
                        }
                        
                        if (max == currCount && start == currStart && currSum >= sum)
                        {
                            if (currSum > sum)
                            {
                                save = input;
                                bestSample = sample;
                                sum = currSum;
                                continue;
                            }
                                
                            
                        }

                    }

                }

                

            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {sum}.");
            Console.WriteLine(String.Join(" ", save));
        }
    }
}
