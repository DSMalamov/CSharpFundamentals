using System;
using System.Text;

namespace _09.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;
                int startName = input.IndexOf('@') + 1;
                int endName = input.IndexOf('|');
                int startAge = input.IndexOf('#') + 1;
                int endAge = input.IndexOf('*');

                for (int j = startName; j < endName ; j++)
                {
                    name += (input[j]);
                }
                for (int k = startAge; k < endAge; k++)
                {
                    age += (input[k]);
                }
                
                Console.WriteLine($"{name} is {age} years old.");
            }

            
        }
    }
}
