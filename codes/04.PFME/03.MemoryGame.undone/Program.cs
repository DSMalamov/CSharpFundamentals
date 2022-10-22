using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame.undone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            int numberOfMoves = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                numberOfMoves ++;

                int[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int index1 = cmdArg[0];
                int index2 = cmdArg[1];

                if (index1 < 0 || index2 < 0 || index1 >= input.Count || index2 >= input.Count || index1 == index2)
                {
                    CheckForCheat(input, numberOfMoves);
                    continue;
                }

                if (input[index1] == input[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {input[index1]}!");

                    if (index1 > index2)
                    {
                        input.RemoveAt(index1);
                        input.RemoveAt(index2);
                    }
                    else
                    {
                        input.RemoveAt(index2);
                        input.RemoveAt(index1);
                    }

                }
                else if (input[index1] != input[index2])
                {
                    Console.WriteLine("Try again!");
                }

                if (input.Count <= 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    break;
                }

            }

            if (input.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", input));
            }
        }

        static void CheckForCheat(List<string> input, int numberOfMoves)
        {
            int middle = input.Count / 2;

            input.Insert(middle, $"-{numberOfMoves}a");
            input.Insert(middle, $"-{numberOfMoves}a");
            Console.WriteLine("Invalid input! Adding additional elements to the board");
            
        }
    }
}
