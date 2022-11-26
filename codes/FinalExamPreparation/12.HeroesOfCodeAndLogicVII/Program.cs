using System;
using System.Collections.Generic;

namespace _12.HeroesOfCodeAndLogicVII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            //List contains at 0 hp and at 1 mp

            for (int i = 0; i < n; i++)
            {
                string[] heroArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroArg[0];
                int healthPoints = int.Parse(heroArg[1]);
                int manaPoints = int.Parse(heroArg[2]);

                heroes[heroName] = new List<int> { healthPoints, manaPoints };

            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string cmdInfo = cmdArg[0];
                string heroName = cmdArg[1];

                if (cmdInfo == "CastSpell")
                {
                    int mandNeeded = int.Parse(cmdArg[2]);
                    string spell = cmdArg[3];

                    if (heroes[heroName][1] >= mandNeeded)
                    {
                        heroes[heroName][1] -= mandNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }
                }
                else if (cmdInfo == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];

                    heroes[heroName][0] -= damage;

                    if (heroes[heroName][0] <= 0)
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                }
                else if (cmdInfo == "Recharge")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if (heroes[heroName][1] + amount > 200)
                    {
                        amount = 200 - heroes[heroName][1];
                    }

                    heroes[heroName][1] += amount;

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (cmdInfo == "Heal")
                {
                    int amount = int.Parse(cmdArg[2]);

                    if (heroes[heroName][0] + amount > 100)
                    {
                        amount = 100 - heroes[heroName][0];
                    }

                    heroes[heroName][0] += amount;

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }

            foreach (var kvp in heroes)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {heroes[kvp.Key][0]}");
                Console.WriteLine($"  MP: {heroes[kvp.Key][1]}");
            }
        }
    }
}
