using System;

namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charr = char.Parse(Console.ReadLine());
            int valueOfTheChar = (int)charr;

            if (valueOfTheChar >= 65 && valueOfTheChar <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (valueOfTheChar >= 97 && valueOfTheChar <= 122)
            {
                Console.WriteLine("lower-case");
            }
          
        }
    }
}
