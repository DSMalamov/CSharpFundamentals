using System;

namespace _01.Counter_Strike.undone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int wonBattles = 0;
            string command;

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance <= energy)
                {
                    wonBattles++;
                    energy -= distance;

                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    break;
                }
 
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
            }
        }
    }
}
