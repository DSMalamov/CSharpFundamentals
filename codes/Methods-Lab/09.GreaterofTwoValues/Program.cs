using System;

namespace _09.GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int result = GetMaxInt(a, b);
                    Console.WriteLine(result);
                    break;
                case "string":
                    string c = Console.ReadLine();
                    string d = Console.ReadLine();
                    string results = GetMaxString(c, d);
                    Console.WriteLine(results);
                    break;
                case "char":
                    char e = char.Parse(Console.ReadLine());
                    char f = char.Parse(Console.ReadLine());
                    char resultc = GetMaxChar(e, f);
                    Console.WriteLine(resultc);
                    break;
            }
        }
        static int GetMaxInt(int a, int b)
        { 
            int curMaxint = Math.Max(a, b);
            return curMaxint; 
        }
        static char GetMaxChar(char a, char b)
        {
            char biggerChar = b;

            if (a > b)
            {
                 biggerChar = a;
            }
            
            return biggerChar;
        }
        static string GetMaxString(string c, string d)
        {
            int valueA = 0;
            int valueB = 0;
            string result = string.Empty;

            for (int i = 0; i < c.Length; i++)
            {
                valueA += c[i];
            }
            for (int j = 0; j < d.Length; j++)
            {
                valueB += d[j];
            }

            if (valueA>valueB)
            {
                result = c;
            }
            else
            {
                result = d;
            }

            return result;
        }
    }
}
