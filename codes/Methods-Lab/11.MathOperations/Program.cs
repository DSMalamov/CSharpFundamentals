using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operatorr= Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, operatorr, b));

        }
        static double Calculate(int a, string operatorr, int b)
        {
            double result = 0;

            switch (operatorr)
            {
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "-":
                    result = a - b;
                    break;

            }
            return result;

        }
    }
}
