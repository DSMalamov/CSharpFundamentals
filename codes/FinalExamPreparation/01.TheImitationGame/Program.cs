using System;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] cmdArg = command
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string commandInfo = cmdArg[0];

                if (commandInfo == "Move")
                {
                    int numLetters = int.Parse(cmdArg[1]);

                    string substring = input.Substring(0, numLetters);

                    input = input.Remove(0, numLetters);

                    input += substring;

                }
                else if (commandInfo == "Insert")
                {
                    int index = int.Parse(cmdArg[1]);
                    string value = cmdArg[2];

                    input = input.Insert(index, value);
                }
                else if (commandInfo == "ChangeAll")
                {
                    string substring = cmdArg[1];
                    string replacement = cmdArg[2];

                    input = input.Replace(substring, replacement);
                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
