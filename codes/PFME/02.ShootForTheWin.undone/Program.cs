using System;
using System.Linq;

namespace _02.ShootForTheWin.undone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int shotTargets = 0;
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index >= 0 && index < target.Length)
                {
                    if (target[index] != -1)
                    {
                        int targetCopy = target[index];
                        target[index] = -1;

                        for (int i = 0; i < target.Length; i++)
                        {

                            if (target[i] <= targetCopy && target[i] != -1)
                            {
                                target[i] += targetCopy;
                            }
                            else if (target[i] > targetCopy && target[i] != -1)
                            {
                                target[i] -= targetCopy;
                            }
                        }

                        shotTargets++;

                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", target)}");
        }
    }
}
