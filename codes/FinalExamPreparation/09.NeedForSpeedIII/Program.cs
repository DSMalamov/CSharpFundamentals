using System;
using System.Collections.Generic;

namespace _09.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();

            //in the int array first index is mileage the second is fuel.

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currCar = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string carName = currCar[0];
                int mileage = int.Parse(currCar[1]);
                int fuel = int.Parse(currCar[2]);

                cars[carName] = new int[] {mileage, fuel};
            }

            string command;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];
                string carName = cmdArg[1];

                if (cmdInfo == "Drive")
                {
                    int distance = int.Parse(cmdArg[2]);
                    int fuel = int.Parse(cmdArg[3]);

                    if (cars[carName][1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else 
                    {
                        cars[carName][1] -= fuel;
                        cars[carName][0] += distance;

                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (cars[carName][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            cars.Remove(carName);
                        }
                    }
                }
                else if (cmdInfo == "Refuel")
                {
                    int fuel = int.Parse(cmdArg[2]);

                    if (cars[carName][1] + fuel > 75)
                    {
                        fuel = 75 - cars[carName][1];
                    }

                    cars[carName][1] += fuel;

                    Console.WriteLine($"{carName} refueled with {fuel} liters");
                }
                else if (cmdInfo == "Revert")
                {
                    int kilometers = int.Parse(cmdArg[2]);

                    if (cars[carName][0] - kilometers < 10000)
                    {
                        cars[carName][0] = 10000;  
                    }
                    else
                    {
                        cars[carName][0] -= kilometers;
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var kvp in cars)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value[0]} kms, Fuel in the tank: {kvp.Value[1]} lt.");
            }
        }
    }
}
