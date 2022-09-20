using System;

namespace _14.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double budgetCopy = budget;

            while (game != "Game Time")
            {
                
                switch (game)
                {
                    case "OutFall 4":
                        if (budget >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        if (budget >= 15.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 15.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (budget >= 19.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 19.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (budget >= 59.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 59.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (budget >= 29.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 29.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (budget >= 39.99)
                        {
                            Console.WriteLine($"Bought {game}");
                            budget -= 39.99;
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                        default:
                            Console.WriteLine("Not Found");
                        break;

                   
                }
                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    Environment.Exit(0);
                }
                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${budgetCopy - budget:f2}. Remaining: ${budget:f2}");
        }
    }
}
