using System;
using System.Linq;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
            string[] second = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < second.Length; i++)
            {
                var currIndex1 = second[i];
                
                
                for (int j = 0; j < first.Length; j++)
                {
                    var currIndex2 = first[j];
                    if (currIndex1 == currIndex2)
                    {
                        Console.Write(String.Join(" ", currIndex1 + " "));
                    }
                }
            }
                


        }
    }
}
