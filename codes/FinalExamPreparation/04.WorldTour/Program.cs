using System;

namespace _04.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] cmdArg = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);

                string commandInfo = cmdArg[0];

                if (commandInfo == "Add Stop")
                {
                    int index = int.Parse(cmdArg[1]);
                    string substring = cmdArg[2];

                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, substring);
                        
                    }
                    
                }
                else if (commandInfo == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    if ((startIndex >= 0 && startIndex < input.Length) && (endIndex >= 0 && 
                        endIndex < input.Length) && startIndex <= endIndex)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        
                    }
                    
                }
                else if (commandInfo == "Switch")
                {
                    string oldString = cmdArg[1];
                    string newString = cmdArg[2];

                    if (input.Contains(oldString) && oldString != newString)
                    {
                        input = input.Replace(oldString, newString);
                        
                    }
                    
                }
                Console.WriteLine(input);

            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
