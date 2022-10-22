using System;
using System.Linq;

namespace _18.ManOWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] warship = Console.ReadLine()
               .Split('>', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int maximumHealth = int.Parse(Console.ReadLine());
            bool isItSank = false;

            string command;

            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg[0] == "Fire")
                {
                    int index = int.Parse(cmdArg[1]);
                    int damage = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < warship.Length)
                    {
                        warship[index] -= damage;

                        if (warship[index] <= 0 )
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isItSank = true;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Defend")
                {
                    int index1 = int.Parse(cmdArg[1]);
                    int index2 = int.Parse(cmdArg[2]);
                    int damage = int.Parse(cmdArg[3]);

                    if (index1 >= 0 && index2 >= 0 && index1 < pirateShip.Length && index2 < pirateShip.Length)
                    {
                        for (int i = index1; i <= index2; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isItSank = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Repair")
                {
                    int index = int.Parse(cmdArg[1]);
                    int heal = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < pirateShip.Length)
                    {
                        int currhp = pirateShip[index];

                        if (currhp + heal >= maximumHealth)
                        {
                            pirateShip[index] = maximumHealth;
                        }
                        else
                        {
                            pirateShip[index] += heal;
                        }

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (cmdArg[0] == "Status")
                {
                    int counter = 0;

                    for (int i = 0; i < pirateShip.Length; i++)
                    {

                        if (pirateShip[i] < maximumHealth * 0.2)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }

            }

            if (isItSank)
            {

            }
            else
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warship.Sum()}");
            }

        }
    }
}
