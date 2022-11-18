using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(patern);

            MatchCollection collection = regex.Matches(input);

            Console.WriteLine(String.Join(", ", collection));

        }
    }
}
