using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    while (lift[i] < 4 && people > 0)
                    {
                        lift[i]++;
                        people--;

                        if (people <= 0)
                        {
                            break;
                        }
                    }
                }
            }

            if (people > 0 && lift.All(x => x == 4))
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else if(people <= 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(String.Join(" ", lift));
            }

        }
    }
}
