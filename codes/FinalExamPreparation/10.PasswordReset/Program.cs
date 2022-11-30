using System;
using System.Text;

namespace _10.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];

                if (cmdInfo == "TakeOdd")
                {
                    string rawPass = string.Empty;
                    for (int i = 1; i < input.Length; i += 2)
                    {

                         rawPass += input[i];

                    }

                    input = rawPass;
                    Console.WriteLine(input);
                }
                else if (cmdInfo == "Cut")
                {
                    int index = int.Parse(cmdArg[1]);
                    int length = int.Parse(cmdArg[2]);

                    string substring = input.Substring(index, length);
                    input = input.Remove(input.IndexOf(substring), substring.Length);
                    
                    Console.WriteLine(input);

                }
                else if (cmdInfo == "Substitute")
                {
                    string substring = cmdArg[1];
                    string substitute = cmdArg[2];
                    
                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
