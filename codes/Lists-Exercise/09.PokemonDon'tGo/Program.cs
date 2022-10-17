using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDon_tGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                int currEl = 0;

                if (index < 0)
                {
                    currEl = input[0];
                    input[0] = input[input.Count - 1];
                    ModeratingInputAraySC(input, currEl);
                }
                else if (index > input.Count - 1)
                {
                    currEl = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
                    ModeratingInputAraySC(input, currEl);
                }
                else
                {
                    currEl = input[index];
                    ModeratingInputAray(input, index, currEl);
                }
                sum += currEl;

            }
            Console.WriteLine(sum);
        }
        static void ModeratingInputAray (List<int> input, int index, int currEl)
        {
            input.RemoveAt(index);

            for (int i = 0; i < input.Count; i++)
            {
                int elementOfArray = input[i];
                if (elementOfArray <= currEl)
                {
                    input[i] += currEl;
                }
                else if (elementOfArray > currEl)
                {
                    input[i] -= currEl;
                }
            }
        }
        static void ModeratingInputAraySC(List<int> input, int currEl)
        {
            

            for (int i = 0; i < input.Count; i++)
            {
                int elementOfArray = input[i];
                if (elementOfArray <= currEl)
                {
                    input[i] += currEl;
                }
                else if (elementOfArray > currEl)
                {
                    input[i] -= currEl;
                }
            }
        }
    }
}
