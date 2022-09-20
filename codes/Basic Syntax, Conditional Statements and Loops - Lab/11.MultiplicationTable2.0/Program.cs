using System;

namespace dsd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 > 10)
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
                Environment.ExitCode = 0;
            }
            

            for (int i = num2; num2 <= 10; num2++)
            {
               
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
            }
        }
    }
}
