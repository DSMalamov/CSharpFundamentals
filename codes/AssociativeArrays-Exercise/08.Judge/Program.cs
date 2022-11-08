using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, SortedDictionary<string, int>>();
            var userPoints = new SortedDictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "no more time")
            {
                string[] cmdArg = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string contestName = cmdArg[1];
                string username = cmdArg[0];
                int points = int.Parse(cmdArg[2]);

                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new SortedDictionary<string, int>();
                }

                if (!contests[contestName].ContainsKey(username))
                {
                    contests[contestName][username] = 0;

                    if (!userPoints.ContainsKey(username))
                    {
                        userPoints[username] = 0;
                    }
                }

                if (contests[contestName][username] < points)
                {
                    int diff = points - contests[contestName][username];

                    contests[contestName][username] = points;
                    userPoints[username] += diff;
                    
                }
                else if (contests[contestName][username] == 0)
                {
                    userPoints[username] += points;
                }
                

            }

            foreach (var con in contests)
            {
                Console.WriteLine($"{con.Key}: {con.Value.Count} participants");
                int position = 1;
                
                foreach (var userName in con.Value.OrderByDescending(x => x.Value))
                {
                    
                    Console.Write($"{position}. ");
                    Console.WriteLine($"{userName.Key} <::> {userName.Value}");
                    position++;
                }

            }
            
            Console.WriteLine("Individual standings:");

            int position1 = 1;

            foreach (var item in userPoints.OrderByDescending(x => x.Value))
            {
                
                Console.WriteLine($"{position1}. {item.Key} -> {item.Value}");
                position1++;
            }

        }
    }
}
