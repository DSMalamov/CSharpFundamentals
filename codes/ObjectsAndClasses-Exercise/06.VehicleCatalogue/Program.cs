using System;
using System.Collections.Generic;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            command = CollectionFiller(cars, trucks);
            string command2;
            command2 = PrintVehicle(cars, trucks);
            AvarageCarsPower(cars);
            AvarageTrucksPower(trucks);
            
        }

        private static void AvarageTrucksPower(List<Truck> trucks)
        {
            double sum = 0;
            foreach (var truck in trucks)
            {
                sum += truck.Power;
            }
            double avTruckPower = sum / trucks.Count;

            
            if (avTruckPower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avTruckPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }

        private static void AvarageCarsPower(List<Car> cars)
        {
            double sum = 0;
            foreach (var car in cars)
            {
                sum += car.Power;
            }
            double avCarPower = sum / cars.Count;
            if (avCarPower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avCarPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            
        }

        private static string PrintVehicle(List<Car> cars, List<Truck> trucks)
        {
            string command2;
            while ((command2 = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var car in cars)
                {
                    if (car.Model == command2)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Power}");
                    }
                }

                foreach (var truck in trucks)
                {
                    if (truck.Model == command2)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Power}");
                    }
                    
                }
            }

            return command2;
        }

        private static string CollectionFiller(List<Car> cars, List<Truck> trucks)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArg[0];
                string model = cmdArg[1];
                string color = cmdArg[2];
                double power = double.Parse(cmdArg[3]);

                if (type == "car")
                {
                    Car car = new Car(model, color, power);
                    cars.Add(car);
                }
                else if (type == "truck")
                {
                    Truck truck = new Truck(model, color, power);
                    trucks.Add(truck);
                }


            }

            return command;
        }
    }

    public class Car
    {
        public Car (string model, string color, double power)
        {
            Model = model;
            Color = color;
            Power = power;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public double Power { get; set; }
    }
    public class Truck
    {
        public Truck (string model, string color, double power)
        {
            Model = model;
            Color = color;
            Power = power;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public double Power { get; set; }
    }
}
