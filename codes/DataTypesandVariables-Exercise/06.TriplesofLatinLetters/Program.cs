﻿using System;

namespace _06.TriplesofLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write($"{(char)('a' + i)}{(char)('a' + j)}{(char)('a' + k)}");
                        Console.WriteLine("");
                    }
                }
                
            }
            
        }
    }
}
