using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Catalogue catalogue = new Catalogue();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArg[0];

                if (type == "Truck")
                {
                    string brand = cmdArg[1];
                    string model = cmdArg[2];
                    int weight = int.Parse(cmdArg[3]);

                    Truck truck = new Truck(brand, model, weight);
                    catalogue.Trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    string brand = cmdArg[1];
                    string model = cmdArg[2];
                    int power = int.Parse(cmdArg[3]);

                    Car car = new Car (brand, model, power);
                    catalogue.Cars.Add(car);
                }
            }
            Console.WriteLine("Cars:");
            foreach (var item in catalogue.Cars.OrderBy(x => x.Brand))
            {
                
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Power}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var item in catalogue.Trucks.OrderBy(x => x.Brand))
            {
                
                Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
            }
        }
    }
    public class Catalogue
    {
        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }

    }
    public class Truck 
    { 
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    { 
        public Car(string brand, string model, int power)
        {
            Brand = brand;
            Model = model;
            Power = power;
        }

        public string Brand { get; set; } 
        public string Model { get; set; }
        public int Power { get; set; }
    }
}
