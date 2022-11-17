using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currPhrase = phrases[random.Next(0, 6)];
                string currEvent = events[random.Next(0, 6)];
                string currAuthor = authors[random.Next(0, 7)];
                string currCity = cities[random.Next(0, 5)];

                Console.WriteLine($"{currPhrase} {currEvent} {currAuthor} – {currCity}.");
            }
        }
    }
}
