using System;

namespace _14.MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int room = 0;
            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] currRoom = input[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                room++;

                if (currRoom[0] == "potion")
                {
                    int hp = int.Parse(currRoom[1]);

                    int healedAmount = 0;

                    if (health + hp > 100)
                    {
                        int excesiveHP = health + hp - 100;
                        healedAmount =  hp - excesiveHP;
                        health = 100;
                    }
                    else
                    {
                        healedAmount = hp;
                        health += hp;
                    }

                    Console.WriteLine($"You healed for {healedAmount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (currRoom[0] == "chest")
                {
                    bitcoins += int.Parse(currRoom[1]);
                    Console.WriteLine($"You found {int.Parse(currRoom[1])} bitcoins.");

                }
                else
                {
                    int atk = int.Parse(currRoom[1]);

                    if (health > atk)
                    {
                        health -= atk;
                        Console.WriteLine($"You slayed {currRoom[0]}.");
                    }
                    else
                    {
                        health -= atk;
                        Console.WriteLine($"You died! Killed by {currRoom[0]}.");
                        Console.WriteLine($"Best room: {room}");
                        break;
                    }
                }

            }

            if (health>0 && room == input.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
