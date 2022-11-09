using System;

namespace _05.DigitsLettersandOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string digits = string.Empty;
            string letters = string.Empty;
            string chars = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];

                if (char.IsDigit(currCh))
                {
                    digits += currCh;
                }
                else if (char.IsLetter(currCh))
                {
                    letters += currCh;
                }
                else
                {
                    chars += currCh;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}
