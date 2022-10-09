using System;
using System.Numerics;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double result = MathPowering(n1, n2);
            Console.WriteLine(result);
        }
        static double MathPowering(double n1, double n2) 
        {
            double result = Math.Pow( n1, n2);
            return result;
        }
    }
}
