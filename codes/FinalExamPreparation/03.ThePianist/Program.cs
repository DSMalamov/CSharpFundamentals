using System;
using System.Collections.Generic;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                dict.Add(piece, new string[] { composer, key });

            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string action = cmdArg[0];

                if (action == "Add")
                {
                    if (!dict.ContainsKey(cmdArg[1]))
                    {
                        dict.Add(cmdArg[1], new string[] { cmdArg[2], cmdArg[3]});

                        Console.WriteLine($"{cmdArg[1]} by {cmdArg[2]} in {cmdArg[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArg[1]} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    string piece = cmdArg[1];

                    if (dict.ContainsKey(piece))
                    {
                        dict.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    
                }
                else if (action == "ChangeKey")
                {
                    string piece = cmdArg[1];
                    string newKey = cmdArg[2];

                    if (dict.ContainsKey(piece))
                    {
                        dict[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
