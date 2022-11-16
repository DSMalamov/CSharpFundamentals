using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Box> boxes = new List<Box>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = cmdArg[0];
                string itemName = cmdArg[1];
                int itemQuantity = int.Parse(cmdArg[2]);
                decimal itemPrice = decimal.Parse(cmdArg[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);

            }

            foreach (var item in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:f2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.PricePerBox:f2}");
            }
        }
    }
    public class Box 
    {
        public Box (string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public decimal PricePerBox 
        { 
            get
            {
                return Quantity * Item.Price;
            }

        }

    
    }
    public class Item
    { 
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
