using System;
using System.Linq;

namespace _04.ReverseArrayofStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(" ");
                
            for (int i = array.Length - 1; i >= 0; i--)
            {
                var currEl = array[i];
                Console.Write(currEl + " ");
            }

        }
    }
}
