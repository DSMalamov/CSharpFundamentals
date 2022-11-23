using System;
using System.Text.RegularExpressions;

namespace _11.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

            Regex barcode = new Regex(pattern);
            Regex productGroup = new Regex(@"\d+");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = barcode.Match(input);

                if (match.Success)
                {
                    MatchCollection matches = productGroup.Matches(input);
                    string result = String.Empty;

                    foreach (Match item in matches)
                    {
                        result += item.Value;
                    }

                    if (result == String.Empty)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {result}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }


        }
    }
}
