using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var licensePlateRegister = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArg[0];
                string username = cmdArg[1];

                if (command == "register")
                {
                    string lpNumber = cmdArg[2];

                    if (!licensePlateRegister.ContainsKey(username))
                    {
                        licensePlateRegister[username] = lpNumber;
                        Console.WriteLine($"{username} registered {lpNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {lpNumber}");
                    }

                }
                if (command == "unregister")
                {
                    if (licensePlateRegister.ContainsKey(username))
                    {
                        licensePlateRegister.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var item in licensePlateRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
