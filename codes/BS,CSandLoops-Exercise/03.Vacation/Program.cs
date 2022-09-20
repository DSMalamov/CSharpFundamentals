using System;

namespace _03.Vacation
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = peopleCount * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = peopleCount * 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = peopleCount * 10.46;
                    }

                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }

                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = peopleCount * 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = peopleCount * 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = peopleCount * 16.00;
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        totalPrice = peopleCount * 15.00;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        totalPrice = peopleCount * 20.00;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        totalPrice = peopleCount * 22.50;
                    }

                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
