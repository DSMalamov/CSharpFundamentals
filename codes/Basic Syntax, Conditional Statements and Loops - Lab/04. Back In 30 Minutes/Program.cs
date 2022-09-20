using System;

namespace x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMin = minutes + 30;

            if (totalMin > 59)
            {
                hours += 1;
                totalMin -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{totalMin:d2}");
        }
    }
}
