using System;

namespace dd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            int number = 1;
            int sum = 0;
            
            for (int i = 0; i < loops; i++)
            {
                Console.WriteLine(number);
                
                sum += number;
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
