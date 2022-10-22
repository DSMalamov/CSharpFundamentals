using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArg = command
                    .Split(' ');

                if (cmdArg[0] == "Urgent")
                {
                    if (shopingList.Contains(cmdArg[1]))
                    {
                        continue;
                    }
                    
                    shopingList.Insert(0, cmdArg[1]);

                }
                else if (cmdArg[0] == "Unnecessary")
                {
                    if (!shopingList.Contains(cmdArg[1]))
                    {
                        continue;
                    }

                    shopingList.Remove(cmdArg[1]);

                }
                else if (cmdArg[0] == "Correct")
                {
                    if (shopingList.Contains(cmdArg[1]))
                    {
                        for (int i = 0; i < shopingList.Count; i++)
                        {
                            if (shopingList[i] == cmdArg[1])
                            {
                                shopingList[i] = cmdArg[2];
                                continue;
                            }
                        }
                    }
                    
                }
                else if (cmdArg[0] == "Rearrange")
                {
                    if (shopingList.Contains(cmdArg[1]))
                    {
                        string copy =cmdArg[1];
                        shopingList.Remove(cmdArg[1]);
                        shopingList.Add(copy);
                    }
                }
                

            }

            Console.WriteLine(String.Join(", ", shopingList));

        }
    }
}
