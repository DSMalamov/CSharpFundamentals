using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            

            string command;

            while ((command = Console.ReadLine()) != "Season end")
            {
                string[] cmdArg = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArg.Length == 5)
                {
                    string player = cmdArg[0];
                    string position = cmdArg[2];
                    int skill = int.Parse(cmdArg[4]);

                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>();
                        players[player][position] = 0;
                    }
                    else
                    {
                        players[player].Add(position, 0);
                    }

                    if (players[player][position] < skill)
                    {
                        players[player][position] = skill;
                    }

                }
                else if (cmdArg.Length == 3)
                {
                    string player1 = cmdArg[0];
                    string player2 = cmdArg[2];

                    string playerToRemove = "";
                    
                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        foreach (var pos1 in players[player1])
                        {
                            foreach (var pos2 in players[player2])
                            {
                                if (pos1.Key == pos2.Key)
                                {
                                    if (players[player1].Values.Sum() < players[player2].Values.Sum())
                                    {
                                        playerToRemove = player1;
                                    }
                                    else if (players[player1].Values.Sum() > players[player2].Values.Sum())
                                    {
                                        playerToRemove = player2;
                                    }
                                }
                            }
                        }
                    }
                    

                    players.Remove(playerToRemove);
                    
                }

            }
            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var pair in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }

}
