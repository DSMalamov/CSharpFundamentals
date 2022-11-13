using System;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());

                }

                if (power > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    power--;
                    i--;
                }
            }

            Console.WriteLine(input.ToString());
        }
    }
}
