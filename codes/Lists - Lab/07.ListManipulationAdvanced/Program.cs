using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            bool check = false;
            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] cmdArg = comand
                    .Split();
                if (cmdArg[0] == "Add" || cmdArg[0] == "Remove" || cmdArg[0] == "RemoveAt" || cmdArg[0] == "Insert")
                {
                    check = true;
                }

                switch (cmdArg[0])
                {
                    case "Add":
                        int addedNumber = int.Parse(cmdArg[1]);
                        input.Add(addedNumber);
                        break;
                    case "Remove":
                        int removedNumber = int.Parse(cmdArg[1]);
                        input.Remove(removedNumber);
                        break;
                    case "RemoveAt":
                        int removedAt = int.Parse(cmdArg[1]);
                        input.RemoveAt(removedAt);
                        break;
                    case "Insert":
                        int number = int.Parse(cmdArg[1]);
                        int index = int.Parse(cmdArg[2]);
                        input.Insert(index, number);
                        break;
                    case "Contains":
                        int numberc = int.Parse(cmdArg[1]);
                        if (input.Contains(numberc) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < input.Count; i++)
                        {
                            int currNum = input[i];
                            if (currNum % 2 == 0)
                            {
                                Console.Write(currNum + " ");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < input.Count; i++)
                        {
                            int currNum = input[i];
                            if (currNum % 2 != 0)
                            {
                                Console.Write(currNum + " ");
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "GetSum":
                        Console.WriteLine(input.Sum());
                        break;
                    case "Filter":
                        string condition = cmdArg[1];
                        int number2 = int.Parse(cmdArg[2]);
                        if (condition == ">")
                        {
                            Console.WriteLine(String.Join(" ", input.Where(x => x > number2)));
                        }
                        else if (condition == ">=")
                        {
                            Console.WriteLine(String.Join(" ", input.Where(x => x >= number2)));
                        }
                        else if (condition == "<")
                        {
                            Console.WriteLine(String.Join(" ", input.Where(x => x < number2)));
                        }
                        else if (condition == "<=")
                        {
                            Console.WriteLine(String.Join(" ", input.Where(x => x <= number2)));
                        }
                        break;

                }
            }

            if (check == true)
            {
                Console.WriteLine(String.Join(" ", input));
            }
            


        }
    }
}
