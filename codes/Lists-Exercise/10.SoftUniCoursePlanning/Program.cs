using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", " , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArg = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Add")
                {
                    if (!input.Contains(cmdArg[1]))
                    {
                        input.Add(cmdArg[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Insert")
                {
                    if (!input.Contains(cmdArg[1]))
                    {
                        int index = int.Parse(cmdArg[2]);
                        input.Insert(index, cmdArg[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Remove")
                {
                    if (input.Contains(cmdArg[1]))
                    {
                        input.Remove(cmdArg[1]);
                        if (input.Contains($"{cmdArg[1]}-Exercise"))
                        {
                            input.Remove($"{cmdArg[1]}-Exercise");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Swap")
                {
                    if (input.Contains(cmdArg[1]) && input.Contains(cmdArg[2]))
                    {
                        int index1 = 0;
                        int index2 = 0;
                        string copyOf1 = cmdArg[1];

                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == cmdArg[1])
                            {
                                index1 = i;
                            }
                            else if (input[i] == cmdArg[2])
                            {
                                index2 = i;
                            }
                        }
                        input.Insert(index1, cmdArg[2]);
                        input.RemoveAt(index1 + 1);
                        input.Insert(index2, cmdArg[1]);
                        input.RemoveAt(index2 + 1);

                        if (input.Contains($"{cmdArg[2]}-Exercise"))
                        {
                            input.Remove($"{cmdArg[2]}-Exercise");
                            input.Insert(index1 + 1, $"{cmdArg[2]}-Exercise");
                            
                        }

                       
                        if (input.Contains($"{cmdArg[1]}-Exercise"))
                        {
                            input.Remove($"{cmdArg[1]}-Exercise");
                            input.Insert(index2 + 1, $"{cmdArg[1]}-Exercise");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Exercise")
                {
                    if (!input.Contains(cmdArg[1]))
                    {
                        input.Add(cmdArg[1]);
                        input.Add($"{cmdArg[1]}-Exercise");
                    }
                    else
                    {
                        int index = 0;
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == cmdArg[1])
                            {
                                index = i;
                            }
                        }
                        input.Insert(index + 1, $"{cmdArg[1]}-Exercise");
                    }
                }

            }

            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
