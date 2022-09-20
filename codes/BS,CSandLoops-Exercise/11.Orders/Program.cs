using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalinc = 0;

            for (int i = 1; i <= n; i++)
            {
                double ppCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double sumOrder = (days * capsulesCount) * ppCapsule;
                totalinc += sumOrder;
                Console.WriteLine($"The price for the coffee is: ${sumOrder:f2}");

            }
            Console.WriteLine($"Total: ${totalinc:f2}");
        }
    }
}
