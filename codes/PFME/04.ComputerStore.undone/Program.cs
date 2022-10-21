using System;

namespace _04.ComputerStore.undone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sWithoutTaxes = 0;

            string command = Console.ReadLine();
            while (command != "special")
            {
                if (command == "regular")
                {
                    break;
                }

                double currPrice = double.Parse(command);

                if (currPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                sWithoutTaxes += currPrice;
                
                command = Console.ReadLine();
            }

            double taxes = sWithoutTaxes * 0.2;
            double sWithTaxes = sWithoutTaxes + taxes;
            

            if (command == "special")
            {
                sWithTaxes *= 0.9;

            }

            if (sWithTaxes <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {sWithTaxes:f2}$");
            }
        }
    }
}
