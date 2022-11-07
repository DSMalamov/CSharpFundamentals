using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();
            
            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArg[0];
                double price = double.Parse(cmdArg[1]);
                int quantity = int.Parse(cmdArg[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new List<double>();
                    products[name].Add(price);
                    products[name].Add(quantity);
                }
                else
                {
                    if (products[name][0] == price)
                    {
                        products[name][1] += quantity;
                    }
                    else
                    {
                        products[name][0] = price;
                        products[name][1] += quantity;
                    }
                }

                
                
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");

            }
        }
    }
}
