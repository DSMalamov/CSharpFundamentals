using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            List<string> guest = new List<string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ');

                if (cmdArg.Length == 3)
                {
                    if (guest.Contains(cmdArg[0]))
                    {
                        Console.WriteLine($"{cmdArg[0]} is already in the list!");
                        continue;
                    }
                    
                    guest.Add(cmdArg[0]);
                }
                else if (cmdArg.Length > 3) 
                {
                    if (!guest.Contains(cmdArg[0]))
                    {
                        Console.WriteLine($"{cmdArg[0]} is not in the list!");
                        continue;
                    }

                    guest.Remove(cmdArg[0]);

                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, guest));
        }
    }
}
