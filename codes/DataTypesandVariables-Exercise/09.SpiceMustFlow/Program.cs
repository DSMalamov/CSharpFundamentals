using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingSource = int.Parse(Console.ReadLine());
            int totalyields = 0;
            int days = 0;
            while (startingSource >= 100)
            {
                totalyields += startingSource;
                days++;
                totalyields -= 26;
                startingSource -= 10;
            }

            totalyields -= 26;
            if (totalyields < 0) 
            { 
                totalyields = 0;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalyields);

        }
    }
}
