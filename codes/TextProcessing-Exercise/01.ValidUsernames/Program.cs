using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            

            for (int i = 0; i < input.Length; i++)
            {
                bool isValid = true;

                if (input[i].Length >= 3 && input[i].Length <= 16)
                {
                    foreach (var item in input[i])
                    {
                        if (!(char.IsLetterOrDigit(item) || item == '_' || item == '-'))
                        {
                            isValid = false;
                            break;
                        }

                    }

                    if (isValid)
                    {
                        Console.WriteLine(input[i]);
                    }

                }

            }
        }
    }
}
