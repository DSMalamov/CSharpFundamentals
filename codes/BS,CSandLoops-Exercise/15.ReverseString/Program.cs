using System;

namespace _15.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string revName = string.Empty;

            for (int i = name.Length - 1; i >= 0 ; i--)
            {
                char cChar = name[i];
                revName += cChar;
            }
            Console.WriteLine(revName);
        }
    }
}
