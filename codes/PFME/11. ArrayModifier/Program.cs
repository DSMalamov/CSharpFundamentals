using System;
using System.Linq;

namespace _11._ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmdArg[0] == "decrease")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] -= 1;
                    }

                    continue;
                }

                int index1 = int.Parse(cmdArg[1]);
                int index2 = int.Parse(cmdArg[2]);

                if (cmdArg[0] == "swap")
                {
                    int copy1 = input[index1];
                    input[index1] = input[index2];
                    input[index2] = copy1;

                }
                else if (cmdArg[0] == "multiply")
                {
                    int result = input[index1] * input[index2];
                    input[index1] = result;
                }
                
                    
            }

            Console.WriteLine(String.Join(", ", input));
        }
    }
}
