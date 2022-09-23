using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            long firstOperation = (long)num1 + num2;
            long secondOperation = firstOperation / num3;
            long thirdOperation = secondOperation * num4;
            Console.WriteLine(thirdOperation);
        }
    }
}
